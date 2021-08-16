﻿using Octokit;
using Semver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;

namespace DSR_Gadget
{
    public partial class FormMain : Form
    {
        private static Properties.Settings settings = Properties.Settings.Default;

        private DSRHook Hook;
        private bool loaded = false;
        private bool reading = false;
        private List<Control> criticalControls;

        public FormMain()
        {
            InitializeComponent();
            Hook = new DSRHook(5000, 5000);
            Hook.OnHooked += DsrProcess_OnHooked;
            Hook.OnUnhooked += DsrProcess_OnUnhooked;
            Hook.Start();
            criticalControls = new List<Control>
            {
                nudHealth, nudStamina, btnPosStore, btnPosRestore, cbxDeathCam, btnWarp, cmbBonfire,
                btnCreate, btnEventRead, btnEventWrite, nudChrType, nudTeamType, nudInvadeType, cbxFreezeChrType,
                cbxFreezeTeamType, cbxFreezeInvadeType, cmbChrSelect, cmbInvasionSelect, cmbAreaID, cmbMPAreaID,
                cbxFreezeMPAreaID, cbxFreezeAreaID, btnTeleportBloodstain, btnTeleportInitialPosition,
                btnResetMagicQuantity, btnLeaveSession, cmbCovenant, nudWarriorOfSunlight, nudDarkwraith,
                nudPathOfTheDragon, nudGravelordServant, nudForestHunter, nudDarkmoonBlade, nudChaosServant,
                btnCurrentPlayerKick, txtName, nudWeaponMemory, nudHair, //nudIndictments,
            };
        }

        private void enableCriticalControls(bool enable)
        {
            foreach (Control ctrl in criticalControls)
                ctrl.Enabled = enable;
        }

        private async void FormMain_Load(object sender, EventArgs e)
        {
            Location = settings.WindowLocation;
            Text = "DSR Gadget " + System.Windows.Forms.Application.ProductVersion;
            enableCriticalControls(false);
            initializeAll();

            llbUpdate.Visible = false;
            GitHubClient gitHubClient = new GitHubClient(new ProductHeaderValue("DSR-Gadget"));
            try
            {
                Release release = await gitHubClient.Repository.Release.GetLatest("Meikk99", "DSR-Gadget");
                if (SemVersion.Parse(release.TagName) > System.Windows.Forms.Application.ProductVersion)
                {
                    lblUpdate.Text = "New version available!";
                    LinkLabel.Link link = new LinkLabel.Link();
                    link.LinkData = release.HtmlUrl;
                    llbUpdate.Links.Add(link);
                    llbUpdate.Visible = true;
                }
                else
                {
                    lblUpdate.Text = "App up to date";
                }
            }
            catch (Exception ex) when (ex is HttpRequestException || ex is ApiException || ex is ArgumentException)
            {
                lblUpdate.Text = "Current app version unknown";
            }
        }

        private void llbUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                settings.WindowLocation = Location;
            else
                settings.WindowLocation = RestoreBounds.Location;

            saveAll();
            resetAll();
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            if (Hook.Hooked)
            {
                if (Hook.Loaded)
                {
                    if (!loaded)
                    {
                        lblLoadedValue.Text = "Yes";
                        loaded = true;
                        reloadAll();
                        enableCriticalControls(true);
                    }
                    else
                    {
                        updateAll();
                    }
                }
                else if (loaded)
                {
                    lblLoadedValue.Text = "No";
                    enableCriticalControls(false);
                    loaded = false;
                }
            }
        }

        private void DsrProcess_OnHooked(object sender, PropertyHook.PHEventArgs e)
        {
            Invoke(new Action(() =>
            {
                lblVersionValue.Text = Hook.Version;
            }));
        }

        private void DsrProcess_OnUnhooked(object sender, PropertyHook.PHEventArgs e)
        {
            Invoke(new Action(() =>
            {
                lblVersionValue.Text = "None";
                lblLoadedValue.Text = "No";
                enableCriticalControls(false);
                loaded = false;
            }));
        }

        private void initializeAll()
        {
            reading = true;
            initPlayer();
            initStats();
            initItems();
            initCheats();
            initGraphics();
            initMisc();
            initHotkeys();
            initInfo();
            reading = true;
        }

        private void reloadAll()
        {
            reading = true;
            reloadPlayer();
            reloadStats();
            reloadItems();
            reloadCheats();
            reloadGraphics();
            reloadMisc();
            reloadHotkeys();
            reloadInfo();
            reading = false;
        }

        private void updateAll()
        {
            reading = true;
            updatePlayer();
            updateStats();
            updateItems();
            updateCheats();
            updateGraphics();
            updateMisc();
            updateHotkeys();
            updateInfo();
            reading = false;
        }

        private void saveAll()
        {
            savePlayer();
            saveStats();
            saveItems();
            saveCheats();
            saveGraphics();
            saveMisc();
            saveHotkeys();
            saveInfo();
        }

        private void resetAll()
        {
            resetPlayer();
            resetStats();
            resetItems();
            resetCheats();
            resetGraphics();
            resetMisc();
            resetHotkeys();
            resetInfo();
        }

        private void nudHair_ValueChanged(object sender, EventArgs e)
        {
            if (loaded && !reading)
                Hook.Hair = (int)nudHair.Value;
        }

        private void nudHairRed_ValueChanged(object sender, EventArgs e)
        {
            if (loaded && !reading)
                Hook.HairRed = (float)nudHairRed.Value;
        }

        private void nudHairGreen_ValueChanged(object sender, EventArgs e)
        {
            if (loaded && !reading)
                Hook.HairGreen = (float)nudHairGreen.Value;
        }

        private void nudHairBlue_ValueChanged(object sender, EventArgs e)
        {
            if (loaded && !reading)
                Hook.HairBlue= (float)nudHairBlue.Value;
        }

        private void nudHairAlpha_ValueChanged(object sender, EventArgs e)
        {
            if (loaded && !reading)
                Hook.HairAlpha = (float)nudHairAlpha.Value;
        }

        private void nudEyeRed_ValueChanged(object sender, EventArgs e)
        {
            if (loaded && !reading)
                Hook.EyeRed = (float)nudEyeRed.Value;
        }

        private void nudEyeGreen_ValueChanged(object sender, EventArgs e)
        {
            if (loaded && !reading)
                Hook.EyeGreen = (float)nudEyeGreen.Value;
        }

        private void nudEyeBlue_ValueChanged(object sender, EventArgs e)
        {
            if (loaded && !reading)
                Hook.EyeBlue = (float)nudEyeBlue.Value;
        }
    }
}
