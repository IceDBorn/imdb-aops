﻿using System;
using System.Drawing;
using System.Windows.Forms;
using filmhub.Models;
using filmhub.Properties;

namespace filmhub.Views
{
    public partial class MainForm : Form
    {
        #region Fields

        private bool _mouseDown;
        private Point _lastLocation;
        
        private Image _home;
        private Image _homeHover;
        
        private Image _search;
        private Image _searchHover;
        
        private Image _account;
        private Image _accountHover;
        
        private Image _close;
        private Image _closeHover;
        
        private Image _minimize;
        private Image _minimizeHover;

        #endregion

        #region Constructor

        public MainForm()
        {
            InitializeComponent();
            InitializeColors();
            InitializeImages();
            UserControlSelector(new WelcomeUserControl(), false);
        }

        #endregion

        #region Methods

        private void InitializeColors()
        {
            favoritesLabel.ForeColor = Program.Colors.ForeColor;
            watchListLabel.ForeColor = Program.Colors.ForeColor;
            historyLabel.ForeColor = Program.Colors.ForeColor;
            settingsLabel.ForeColor = Program.Colors.ForeColor;
            logoutLabel.ForeColor = Program.Colors.ForeColor;
            favoritesLabel.ForeColor = Program.Colors.ForeColor;
            navBar.BackColor = Program.Colors.NavBarBackgroundColor;
            searchBar.BackColor = Program.Colors.FieldColor;
            searchBar.ForeColor = Program.Colors.FieldDarkTextColor;
            mainPage.BackColor = Program.Colors.BackgroundColor;
            favoritesLabel.BackColor = Program.Colors.PopOutBackgroundColor;
            watchListLabel.BackColor = Program.Colors.PopOutBackgroundColor;
            historyLabel.BackColor = Program.Colors.PopOutBackgroundColor;
            settingsLabel.BackColor = Program.Colors.PopOutBackgroundColor;
            logoutLabel.BackColor = Program.Colors.PopOutBackgroundColor;
            dropDownPanel.BackColor = Program.Colors.PopOutBackgroundColor;
            windowBar.BackColor = Program.Colors.WindowBarBackgroundColor;
        }

        private void InitializeImages()
        {
            _home = Resources.home_black;
            homeButton.Image = _home;
            _homeHover = Resources.home_hover;
            
            _search = Resources.search_black;
            searchButton.Image = _search;
            _searchHover = Resources.search_hover;
            
            _account = Resources.account_black;
            accountButton.Image = _account;
            _accountHover = Resources.account_hover;
            
            _close = Resources.close_black;
            close.Image = _close;
            _closeHover = Resources.close_hover;
            
            _minimize = Resources.minimize_black;
            minimize.Image = _minimize;
            _minimizeHover = Resources.minimize_hover;
        }

        public void UserControlSelector(Control userControl, bool flag)
        {
            mainPage.Controls.Clear();
            mainPage.Controls.Add(userControl);
            iconsPanel.Visible = flag;
        }

        public void HideDropDown()
        {
            dropDownPanel.Visible = false;
            accountButton.Image = Resources.account;
            GC.Collect();
        }

        private void ResetAccountButtonImage()
        {
            accountButton.Image = _account;
        }

        #endregion

        #region Events

        private void searchBar_Enter(object sender, EventArgs e)
        {
            if (searchBar.Text.Equals(@" Enter your search"))
            {
                searchBar.Text = "";
            }
        }

        private void searchBar_Leave(object sender, EventArgs e)
        {
            if (searchBar.Text.Equals(""))
            {
                searchBar.Text = @" Enter your search";
            }
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            dropDownPanel.Visible = !dropDownPanel.Visible;
        }

        private void favoritesLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new ListUserControl(favoritesLabel.Text, false), true);
            dropDownPanel.Visible = false;
            ResetAccountButtonImage();
        }

        private void favoritesLabel_MouseHover(object sender, EventArgs e)
        {
            favoritesLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void favoritesLabel_MouseLeave(object sender, EventArgs e)
        {
            favoritesLabel.ForeColor = Program.Colors.ForeColor;
        }

        private void watchListLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new ListUserControl(watchListLabel.Text, false), true);
            dropDownPanel.Visible = false;
            ResetAccountButtonImage();
        }

        private void watchListLabel_MouseHover(object sender, EventArgs e)
        {
            watchListLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void watchListLabel_MouseLeave(object sender, EventArgs e)
        {
            watchListLabel.ForeColor = Program.Colors.ForeColor;
        }

        private void historyLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new ListUserControl(historyLabel.Text, false), true);
            dropDownPanel.Visible = false;
            ResetAccountButtonImage();
        }

        private void historyLabel_MouseHover(object sender, EventArgs e)
        {
            historyLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void historyLabel_MouseLeave(object sender, EventArgs e)
        {
            historyLabel.ForeColor = Program.Colors.ForeColor;
        }

        private void settingsLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new SettingsUserControl(), true);
            dropDownPanel.Visible = false;
            ResetAccountButtonImage();
        }

        private void settingsLabel_MouseHover(object sender, EventArgs e)
        {
            settingsLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void settingsLabel_MouseLeave(object sender, EventArgs e)
        {
            settingsLabel.ForeColor = Program.Colors.ForeColor;
        }

        private void logoutLabel_Click(object sender, EventArgs e)
        {
            Program.MainForm.UserControlSelector(new WelcomeUserControl(), false);
            dropDownPanel.Visible = false;
            ResetAccountButtonImage();
            Account.Logout();
        }

        private void logoutLabel_MouseHover(object sender, EventArgs e)
        {
            logoutLabel.ForeColor = Program.Colors.AccentColor;
        }

        private void logoutLabel_MouseLeave(object sender, EventArgs e)
        {
            logoutLabel.ForeColor = Program.Colors.ForeColor;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            UserControlSelector(new MainPageUserControl(), true);
        }

        private void homeButton_MouseHover(object sender, EventArgs e)
        {
            homeButton.Image = _homeHover;
            GC.Collect();
        }

        private void homeButton_MouseLeave(object sender, EventArgs e)
        {
            homeButton.Image = _home;
            GC.Collect();
        }

        private void searchButton_MouseHover(object sender, EventArgs e)
        {
            searchButton.Image = _searchHover;
            GC.Collect();
        }

        private void searchButton_MouseLeave(object sender, EventArgs e)
        {
            searchButton.Image = _search;
            GC.Collect();
        }

        private void accountButton_MouseHover(object sender, EventArgs e)
        {
            accountButton.Image = _accountHover;
            GC.Collect();
        }

        private void accountButton_MouseLeave(object sender, EventArgs e)
        {
            if (dropDownPanel.Visible) return;
            ResetAccountButtonImage();
            GC.Collect();
        }

        private void iconsPanel_Click(object sender, EventArgs e)
        {
            HideDropDown();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void close_MouseHover(object sender, EventArgs e)
        {
            close.Image = _closeHover;
            GC.Collect();
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.Image = _close;
            GC.Collect();
        }

        private void minimize_MouseHover(object sender, EventArgs e)
        {
            minimize.Image = _minimizeHover;
            GC.Collect();
        }

        private void minimize_MouseLeave(object sender, EventArgs e)
        {
            minimize.Image = _minimize;
            GC.Collect();
        }

        private void windowBar_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        private void windowBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_mouseDown) return;
            Location = new Point(
                (Location.X - _lastLocation.X) + e.X, (Location.Y - _lastLocation.Y) + e.Y);

            Update();
        }

        private void windowBar_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchBar.Text.Trim()) ||
                searchBar.Text.Trim().Equals("Enter your search"))
            {
                return;
            }

            Program.MainForm.UserControlSelector(
                new ListUserControl("Search", false, searchBar.Text.Trim()), true
            );
        }

        private void searchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter || string.IsNullOrEmpty(searchBar.Text.Trim())) return;
            Program.MainForm.UserControlSelector(
                new ListUserControl("Search", false, searchBar.Text.Trim()), true
            );
            e.SuppressKeyPress = true;
        }

        #endregion
    }
}