﻿using System.Drawing;

namespace TRPO_Project
{
    partial class formLogIn
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogIn));
            this.metroLinkRegister = new MetroFramework.Controls.MetroLink();
            this.metroLinkForgotPassword = new MetroFramework.Controls.MetroLink();
            this.EMAILlabel = new MetroFramework.Controls.MetroLabel();
            this.PASSlabel = new MetroFramework.Controls.MetroLabel();
            this.buttonAnimate = new XanderUI.XUIObjectAnimator();
            this.FormStartTransition = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.EllipseForm = new XanderUI.XUIObjectEllipse();
            this.xuiSlidingPanelForgotPass = new XanderUI.XUISlidingPanel();
            this.bunifuImageButtonBACK = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButtonAPPLYforgotPassword = new Bunifu.Framework.UI.BunifuImageButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.textBox_ForgotPass = new Guna.UI.WinForms.GunaLineTextBox();
            this.labelREGISTRATION = new System.Windows.Forms.Label();
            this.xuiSlidingPanelREGISTRATION = new XanderUI.XUISlidingPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ButtonREGISTER = new Bunifu.Framework.UI.BunifuImageButton();
            this.textBoxREPEAT_PASS_reg = new Guna.UI.WinForms.GunaLineTextBox();
            this.textBoxPASS_reg = new Guna.UI.WinForms.GunaLineTextBox();
            this.textBoxEMAIL_reg = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.bunifuImageButtonBACK_Reg = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButtonEXIT = new Bunifu.Framework.UI.BunifuImageButton();
            this.ImageButtonAPPLYlogin = new Bunifu.Framework.UI.BunifuImageButton();
            this.textboxPASSlogin = new Bunifu.Framework.UI.BunifuTextbox();
            this.textboxEMAILlogin = new Bunifu.Framework.UI.BunifuTextbox();
            this.xuiSlidingPanelForgotPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBACK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonAPPLYforgotPassword)).BeginInit();
            this.xuiSlidingPanelREGISTRATION.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonREGISTER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBACK_Reg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonEXIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageButtonAPPLYlogin)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLinkRegister
            // 
            this.metroLinkRegister.BackColor = System.Drawing.Color.Transparent;
            this.metroLinkRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLinkRegister.ForeColor = System.Drawing.Color.Aqua;
            this.metroLinkRegister.Location = new System.Drawing.Point(266, 184);
            this.metroLinkRegister.Name = "metroLinkRegister";
            this.metroLinkRegister.Size = new System.Drawing.Size(75, 23);
            this.metroLinkRegister.TabIndex = 8;
            this.metroLinkRegister.Text = "Register";
            this.metroLinkRegister.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLinkRegister.UseCustomForeColor = true;
            this.metroLinkRegister.UseSelectable = true;
            this.metroLinkRegister.Click += new System.EventHandler(this.metroLinkRegister_Click);
            // 
            // metroLinkForgotPassword
            // 
            this.metroLinkForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLinkForgotPassword.ForeColor = System.Drawing.Color.Aqua;
            this.metroLinkForgotPassword.Location = new System.Drawing.Point(52, 184);
            this.metroLinkForgotPassword.Name = "metroLinkForgotPassword";
            this.metroLinkForgotPassword.Size = new System.Drawing.Size(106, 23);
            this.metroLinkForgotPassword.TabIndex = 9;
            this.metroLinkForgotPassword.Text = "Forgot password";
            this.metroLinkForgotPassword.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLinkForgotPassword.UseCustomForeColor = true;
            this.metroLinkForgotPassword.UseSelectable = true;
            this.metroLinkForgotPassword.Click += new System.EventHandler(this.metroLinkForgotPassword_Click);
            // 
            // EMAILlabel
            // 
            this.EMAILlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EMAILlabel.AutoSize = true;
            this.EMAILlabel.BackColor = System.Drawing.Color.Transparent;
            this.EMAILlabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.EMAILlabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.EMAILlabel.ForeColor = System.Drawing.Color.HotPink;
            this.EMAILlabel.Location = new System.Drawing.Point(165, 11);
            this.EMAILlabel.Name = "EMAILlabel";
            this.EMAILlabel.Size = new System.Drawing.Size(67, 25);
            this.EMAILlabel.Style = MetroFramework.MetroColorStyle.Teal;
            this.EMAILlabel.TabIndex = 12;
            this.EMAILlabel.Text = "EMAIL";
            this.EMAILlabel.UseCustomBackColor = true;
            this.EMAILlabel.UseCustomForeColor = true;
            this.EMAILlabel.UseStyleColors = true;
            // 
            // PASSlabel
            // 
            this.PASSlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PASSlabel.AutoSize = true;
            this.PASSlabel.BackColor = System.Drawing.Color.Transparent;
            this.PASSlabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.PASSlabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.PASSlabel.ForeColor = System.Drawing.Color.HotPink;
            this.PASSlabel.Location = new System.Drawing.Point(144, 70);
            this.PASSlabel.Name = "PASSlabel";
            this.PASSlabel.Size = new System.Drawing.Size(112, 25);
            this.PASSlabel.TabIndex = 13;
            this.PASSlabel.Text = "PASSWORD";
            this.PASSlabel.UseCustomBackColor = true;
            this.PASSlabel.UseCustomForeColor = true;
            this.PASSlabel.UseMnemonic = false;
            this.PASSlabel.UseStyleColors = true;
            // 
            // FormStartTransition
            // 
            this.FormStartTransition.Delay = 1;
            // 
            // EllipseForm
            // 
            this.EllipseForm.CornerRadius = 15;
            this.EllipseForm.EffectedControl = this;
            this.EllipseForm.EffectedForm = this;
            // 
            // xuiSlidingPanelForgotPass
            // 
            this.xuiSlidingPanelForgotPass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.xuiSlidingPanelForgotPass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.xuiSlidingPanelForgotPass.BottomLeft = System.Drawing.Color.Plum;
            this.xuiSlidingPanelForgotPass.BottomRight = System.Drawing.Color.Aquamarine;
            this.xuiSlidingPanelForgotPass.CollapseControl = this.metroLinkForgotPassword;
            this.xuiSlidingPanelForgotPass.Collapsed = true;
            this.xuiSlidingPanelForgotPass.Controls.Add(this.bunifuImageButtonBACK);
            this.xuiSlidingPanelForgotPass.Controls.Add(this.bunifuImageButtonAPPLYforgotPassword);
            this.xuiSlidingPanelForgotPass.Controls.Add(this.gunaLabel1);
            this.xuiSlidingPanelForgotPass.Controls.Add(this.textBox_ForgotPass);
            this.xuiSlidingPanelForgotPass.Controls.Add(this.labelREGISTRATION);
            this.xuiSlidingPanelForgotPass.HideControls = true;
            this.xuiSlidingPanelForgotPass.Location = new System.Drawing.Point(0, 5);
            this.xuiSlidingPanelForgotPass.Name = "xuiSlidingPanelForgotPass";
            this.xuiSlidingPanelForgotPass.PanelWidthCollapsed = 0;
            this.xuiSlidingPanelForgotPass.PanelWidthExpanded = 240;
            this.xuiSlidingPanelForgotPass.PrimerColor = System.Drawing.Color.LightGreen;
            this.xuiSlidingPanelForgotPass.Size = new System.Drawing.Size(0, 241);
            this.xuiSlidingPanelForgotPass.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiSlidingPanelForgotPass.TabIndex = 16;
            this.xuiSlidingPanelForgotPass.TopLeft = System.Drawing.SystemColors.Highlight;
            this.xuiSlidingPanelForgotPass.TopRight = System.Drawing.Color.CornflowerBlue;
            this.xuiSlidingPanelForgotPass.Visible = false;
            // 
            // bunifuImageButtonBACK
            // 
            this.bunifuImageButtonBACK.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButtonBACK.Image = global::TRPO_Project.Properties.Resources.back;
            this.bunifuImageButtonBACK.ImageActive = null;
            this.bunifuImageButtonBACK.Location = new System.Drawing.Point(199, 203);
            this.bunifuImageButtonBACK.Name = "bunifuImageButtonBACK";
            this.bunifuImageButtonBACK.Size = new System.Drawing.Size(38, 35);
            this.bunifuImageButtonBACK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonBACK.TabIndex = 23;
            this.bunifuImageButtonBACK.TabStop = false;
            this.bunifuImageButtonBACK.Zoom = 10;
            // 
            // bunifuImageButtonAPPLYforgotPassword
            // 
            this.bunifuImageButtonAPPLYforgotPassword.BackColor = System.Drawing.Color.SlateGray;
            this.bunifuImageButtonAPPLYforgotPassword.Image = global::TRPO_Project.Properties.Resources.X;
            this.bunifuImageButtonAPPLYforgotPassword.ImageActive = null;
            this.bunifuImageButtonAPPLYforgotPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuImageButtonAPPLYforgotPassword.Location = new System.Drawing.Point(23, 136);
            this.bunifuImageButtonAPPLYforgotPassword.Name = "bunifuImageButtonAPPLYforgotPassword";
            this.bunifuImageButtonAPPLYforgotPassword.Size = new System.Drawing.Size(202, 50);
            this.bunifuImageButtonAPPLYforgotPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonAPPLYforgotPassword.TabIndex = 22;
            this.bunifuImageButtonAPPLYforgotPassword.TabStop = false;
            this.bunifuImageButtonAPPLYforgotPassword.Zoom = 10;
            this.bunifuImageButtonAPPLYforgotPassword.Click += new System.EventHandler(this.bunifuImageButtonAPPLYforgotPassword_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.gunaLabel1.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gunaLabel1.Location = new System.Drawing.Point(89, 59);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(77, 25);
            this.gunaLabel1.TabIndex = 21;
            this.gunaLabel1.Text = "EMAIL";
            // 
            // textBox_ForgotPass
            // 
            this.textBox_ForgotPass.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBox_ForgotPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_ForgotPass.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textBox_ForgotPass.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ForgotPass.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBox_ForgotPass.LineColor = System.Drawing.Color.MediumSpringGreen;
            this.textBox_ForgotPass.Location = new System.Drawing.Point(23, 93);
            this.textBox_ForgotPass.Name = "textBox_ForgotPass";
            this.textBox_ForgotPass.PasswordChar = '\0';
            this.textBox_ForgotPass.Size = new System.Drawing.Size(202, 28);
            this.textBox_ForgotPass.TabIndex = 20;
            this.textBox_ForgotPass.TextChanged += new System.EventHandler(this.textBox_ForgotPass_TextChanged);
            // 
            // labelREGISTRATION
            // 
            this.labelREGISTRATION.AutoEllipsis = true;
            this.labelREGISTRATION.AutoSize = true;
            this.labelREGISTRATION.BackColor = System.Drawing.Color.Transparent;
            this.labelREGISTRATION.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelREGISTRATION.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelREGISTRATION.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelREGISTRATION.Location = new System.Drawing.Point(18, 6);
            this.labelREGISTRATION.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelREGISTRATION.Name = "labelREGISTRATION";
            this.labelREGISTRATION.Size = new System.Drawing.Size(207, 25);
            this.labelREGISTRATION.TabIndex = 19;
            this.labelREGISTRATION.Text = "FORGOT PASSWORD";
            // 
            // xuiSlidingPanelREGISTRATION
            // 
            this.xuiSlidingPanelREGISTRATION.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.xuiSlidingPanelREGISTRATION.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.xuiSlidingPanelREGISTRATION.BottomLeft = System.Drawing.Color.DeepSkyBlue;
            this.xuiSlidingPanelREGISTRATION.BottomRight = System.Drawing.Color.Fuchsia;
            this.xuiSlidingPanelREGISTRATION.CollapseControl = this.metroLinkRegister;
            this.xuiSlidingPanelREGISTRATION.Collapsed = true;
            this.xuiSlidingPanelREGISTRATION.Controls.Add(this.bunifuCustomLabel1);
            this.xuiSlidingPanelREGISTRATION.Controls.Add(this.ButtonREGISTER);
            this.xuiSlidingPanelREGISTRATION.Controls.Add(this.textBoxREPEAT_PASS_reg);
            this.xuiSlidingPanelREGISTRATION.Controls.Add(this.textBoxPASS_reg);
            this.xuiSlidingPanelREGISTRATION.Controls.Add(this.textBoxEMAIL_reg);
            this.xuiSlidingPanelREGISTRATION.Controls.Add(this.gunaLabel3);
            this.xuiSlidingPanelREGISTRATION.Controls.Add(this.gunaLabel2);
            this.xuiSlidingPanelREGISTRATION.Controls.Add(this.gunaLabel4);
            this.xuiSlidingPanelREGISTRATION.Controls.Add(this.bunifuImageButtonBACK_Reg);
            this.xuiSlidingPanelREGISTRATION.HideControls = true;
            this.xuiSlidingPanelREGISTRATION.Location = new System.Drawing.Point(0, 5);
            this.xuiSlidingPanelREGISTRATION.Name = "xuiSlidingPanelREGISTRATION";
            this.xuiSlidingPanelREGISTRATION.PanelWidthCollapsed = 0;
            this.xuiSlidingPanelREGISTRATION.PanelWidthExpanded = 345;
            this.xuiSlidingPanelREGISTRATION.PrimerColor = System.Drawing.Color.Black;
            this.xuiSlidingPanelREGISTRATION.Size = new System.Drawing.Size(0, 241);
            this.xuiSlidingPanelREGISTRATION.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiSlidingPanelREGISTRATION.TabIndex = 24;
            this.xuiSlidingPanelREGISTRATION.TopLeft = System.Drawing.Color.LightSeaGreen;
            this.xuiSlidingPanelREGISTRATION.TopRight = System.Drawing.Color.DarkGreen;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(85, 3);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(193, 29);
            this.bunifuCustomLabel1.TabIndex = 24;
            this.bunifuCustomLabel1.Text = "REGISTRATION";
            // 
            // ButtonREGISTER
            // 
            this.ButtonREGISTER.BackColor = System.Drawing.Color.SlateGray;
            this.ButtonREGISTER.Image = global::TRPO_Project.Properties.Resources.X;
            this.ButtonREGISTER.ImageActive = null;
            this.ButtonREGISTER.Location = new System.Drawing.Point(101, 190);
            this.ButtonREGISTER.Name = "ButtonREGISTER";
            this.ButtonREGISTER.Size = new System.Drawing.Size(155, 40);
            this.ButtonREGISTER.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonREGISTER.TabIndex = 31;
            this.ButtonREGISTER.TabStop = false;
            this.ButtonREGISTER.Zoom = 10;
            this.ButtonREGISTER.Click += new System.EventHandler(this.ButtonREGISTER_Click);
            // 
            // textBoxREPEAT_PASS_reg
            // 
            this.textBoxREPEAT_PASS_reg.BackColor = System.Drawing.Color.RoyalBlue;
            this.textBoxREPEAT_PASS_reg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxREPEAT_PASS_reg.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textBoxREPEAT_PASS_reg.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxREPEAT_PASS_reg.ForeColor = System.Drawing.Color.SpringGreen;
            this.textBoxREPEAT_PASS_reg.LineColor = System.Drawing.Color.MintCream;
            this.textBoxREPEAT_PASS_reg.Location = new System.Drawing.Point(69, 158);
            this.textBoxREPEAT_PASS_reg.Name = "textBoxREPEAT_PASS_reg";
            this.textBoxREPEAT_PASS_reg.PasswordChar = '●';
            this.textBoxREPEAT_PASS_reg.Size = new System.Drawing.Size(220, 26);
            this.textBoxREPEAT_PASS_reg.TabIndex = 30;
            this.textBoxREPEAT_PASS_reg.UseSystemPasswordChar = true;
            this.textBoxREPEAT_PASS_reg.TextChanged += new System.EventHandler(this.textBoxREPEAT_PASS_TextChanged);
            // 
            // textBoxPASS_reg
            // 
            this.textBoxPASS_reg.BackColor = System.Drawing.Color.RoyalBlue;
            this.textBoxPASS_reg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPASS_reg.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textBoxPASS_reg.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPASS_reg.ForeColor = System.Drawing.Color.SpringGreen;
            this.textBoxPASS_reg.LineColor = System.Drawing.Color.MintCream;
            this.textBoxPASS_reg.Location = new System.Drawing.Point(69, 107);
            this.textBoxPASS_reg.Name = "textBoxPASS_reg";
            this.textBoxPASS_reg.PasswordChar = '●';
            this.textBoxPASS_reg.Size = new System.Drawing.Size(220, 26);
            this.textBoxPASS_reg.TabIndex = 29;
            this.textBoxPASS_reg.UseSystemPasswordChar = true;
            this.textBoxPASS_reg.TextChanged += new System.EventHandler(this.textBoxPASS_TextChanged);
            // 
            // textBoxEMAIL_reg
            // 
            this.textBoxEMAIL_reg.BackColor = System.Drawing.Color.RoyalBlue;
            this.textBoxEMAIL_reg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEMAIL_reg.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textBoxEMAIL_reg.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEMAIL_reg.ForeColor = System.Drawing.Color.SpringGreen;
            this.textBoxEMAIL_reg.LineColor = System.Drawing.Color.MintCream;
            this.textBoxEMAIL_reg.Location = new System.Drawing.Point(69, 56);
            this.textBoxEMAIL_reg.Name = "textBoxEMAIL_reg";
            this.textBoxEMAIL_reg.PasswordChar = '\0';
            this.textBoxEMAIL_reg.Size = new System.Drawing.Size(220, 26);
            this.textBoxEMAIL_reg.TabIndex = 28;
            this.textBoxEMAIL_reg.TextChanged += new System.EventHandler(this.textBoxEMAIL_TextChanged);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.gunaLabel3.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(97, 136);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(159, 19);
            this.gunaLabel3.TabIndex = 27;
            this.gunaLabel3.Text = "REPEAT PASSWORD";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.gunaLabel2.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(134, 85);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(89, 19);
            this.gunaLabel2.TabIndex = 26;
            this.gunaLabel2.Text = "PASSWORD";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.gunaLabel4.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(151, 34);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(59, 19);
            this.gunaLabel4.TabIndex = 25;
            this.gunaLabel4.Text = "EMAIL";
            // 
            // bunifuImageButtonBACK_Reg
            // 
            this.bunifuImageButtonBACK_Reg.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButtonBACK_Reg.Image = global::TRPO_Project.Properties.Resources.back;
            this.bunifuImageButtonBACK_Reg.ImageActive = null;
            this.bunifuImageButtonBACK_Reg.Location = new System.Drawing.Point(304, 206);
            this.bunifuImageButtonBACK_Reg.Name = "bunifuImageButtonBACK_Reg";
            this.bunifuImageButtonBACK_Reg.Size = new System.Drawing.Size(38, 35);
            this.bunifuImageButtonBACK_Reg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonBACK_Reg.TabIndex = 23;
            this.bunifuImageButtonBACK_Reg.TabStop = false;
            this.bunifuImageButtonBACK_Reg.Zoom = 10;
            // 
            // bunifuImageButtonEXIT
            // 
            this.bunifuImageButtonEXIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuImageButtonEXIT.Image = global::TRPO_Project.Properties.Resources.unnamed;
            this.bunifuImageButtonEXIT.ImageActive = null;
            this.bunifuImageButtonEXIT.InitialImage = global::TRPO_Project.Properties.Resources.unnamed;
            this.bunifuImageButtonEXIT.Location = new System.Drawing.Point(370, 8);
            this.bunifuImageButtonEXIT.Name = "bunifuImageButtonEXIT";
            this.bunifuImageButtonEXIT.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButtonEXIT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonEXIT.TabIndex = 15;
            this.bunifuImageButtonEXIT.TabStop = false;
            this.bunifuImageButtonEXIT.Zoom = 10;
            this.bunifuImageButtonEXIT.Click += new System.EventHandler(this.bunifuImageButtonEXIT_Click);
            // 
            // ImageButtonAPPLYlogin
            // 
            this.ImageButtonAPPLYlogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageButtonAPPLYlogin.BackColor = System.Drawing.Color.Gray;
            this.ImageButtonAPPLYlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageButtonAPPLYlogin.Image = global::TRPO_Project.Properties.Resources.X;
            this.ImageButtonAPPLYlogin.ImageActive = null;
            this.ImageButtonAPPLYlogin.Location = new System.Drawing.Point(52, 132);
            this.ImageButtonAPPLYlogin.Name = "ImageButtonAPPLYlogin";
            this.ImageButtonAPPLYlogin.Size = new System.Drawing.Size(290, 52);
            this.ImageButtonAPPLYlogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageButtonAPPLYlogin.TabIndex = 14;
            this.ImageButtonAPPLYlogin.TabStop = false;
            this.ImageButtonAPPLYlogin.Zoom = 10;
            this.ImageButtonAPPLYlogin.EnabledChanged += new System.EventHandler(this.bunifuImageButtonAPPLYlogin_EnabledChanged);
            this.ImageButtonAPPLYlogin.Click += new System.EventHandler(this.bunifuImageButtonAPPLYlogin_Click);
            // 
            // textboxPASSlogin
            // 
            this.textboxPASSlogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxPASSlogin.BackColor = System.Drawing.Color.Black;
            this.textboxPASSlogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textboxPASSlogin.BackgroundImage")));
            this.textboxPASSlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textboxPASSlogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxPASSlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textboxPASSlogin.ForeColor = System.Drawing.Color.SpringGreen;
            this.textboxPASSlogin.Icon = ((System.Drawing.Image)(resources.GetObject("textboxPASSlogin.Icon")));
            this.textboxPASSlogin.Location = new System.Drawing.Point(52, 98);
            this.textboxPASSlogin.Name = "textboxPASSlogin";
            this.textboxPASSlogin.Size = new System.Drawing.Size(290, 28);
            this.textboxPASSlogin.TabIndex = 11;
            this.textboxPASSlogin.text = "";
            this.textboxPASSlogin.OnTextChange += new System.EventHandler(this.bunifuTextboxPASS_OnTextChange);
            // 
            // textboxEMAILlogin
            // 
            this.textboxEMAILlogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxEMAILlogin.BackColor = System.Drawing.Color.Black;
            this.textboxEMAILlogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textboxEMAILlogin.BackgroundImage")));
            this.textboxEMAILlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textboxEMAILlogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxEMAILlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textboxEMAILlogin.ForeColor = System.Drawing.Color.SpringGreen;
            this.textboxEMAILlogin.Icon = ((System.Drawing.Image)(resources.GetObject("textboxEMAILlogin.Icon")));
            this.textboxEMAILlogin.Location = new System.Drawing.Point(52, 39);
            this.textboxEMAILlogin.Name = "textboxEMAILlogin";
            this.textboxEMAILlogin.Size = new System.Drawing.Size(290, 28);
            this.textboxEMAILlogin.TabIndex = 10;
            this.textboxEMAILlogin.text = "";
            this.textboxEMAILlogin.OnTextChange += new System.EventHandler(this.bunifuTextboxEMAIL_OnTextChange);
            // 
            // formLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(394, 247);
            this.ControlBox = false;
            this.Controls.Add(this.xuiSlidingPanelREGISTRATION);
            this.Controls.Add(this.xuiSlidingPanelForgotPass);
            this.Controls.Add(this.bunifuImageButtonEXIT);
            this.Controls.Add(this.ImageButtonAPPLYlogin);
            this.Controls.Add(this.PASSlabel);
            this.Controls.Add(this.EMAILlabel);
            this.Controls.Add(this.textboxPASSlogin);
            this.Controls.Add(this.textboxEMAILlogin);
            this.Controls.Add(this.metroLinkForgotPassword);
            this.Controls.Add(this.metroLinkRegister);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formLogIn";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.formLogIn_Load);
            this.xuiSlidingPanelForgotPass.ResumeLayout(false);
            this.xuiSlidingPanelForgotPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBACK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonAPPLYforgotPassword)).EndInit();
            this.xuiSlidingPanelREGISTRATION.ResumeLayout(false);
            this.xuiSlidingPanelREGISTRATION.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonREGISTER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBACK_Reg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonEXIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageButtonAPPLYlogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLink metroLinkForgotPassword;
        private MetroFramework.Controls.MetroLink metroLinkRegister;
        private Bunifu.Framework.UI.BunifuTextbox textboxPASSlogin;
        private Bunifu.Framework.UI.BunifuTextbox textboxEMAILlogin;
        private Bunifu.Framework.UI.BunifuImageButton ImageButtonAPPLYlogin;
        private MetroFramework.Controls.MetroLabel PASSlabel;
        private MetroFramework.Controls.MetroLabel EMAILlabel;
        private XanderUI.XUIObjectAnimator buttonAnimate;
        private Bunifu.Framework.UI.BunifuFormFadeTransition FormStartTransition;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonEXIT;
        private XanderUI.XUIObjectEllipse EllipseForm;
        private XanderUI.XUISlidingPanel xuiSlidingPanelForgotPass;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonBACK;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonAPPLYforgotPassword;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLineTextBox textBox_ForgotPass;
        private System.Windows.Forms.Label labelREGISTRATION;
        private XanderUI.XUISlidingPanel xuiSlidingPanelREGISTRATION;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonBACK_Reg;
        private Bunifu.Framework.UI.BunifuImageButton ButtonREGISTER;
        private Guna.UI.WinForms.GunaLineTextBox textBoxREPEAT_PASS_reg;
        private Guna.UI.WinForms.GunaLineTextBox textBoxPASS_reg;
        private Guna.UI.WinForms.GunaLineTextBox textBoxEMAIL_reg;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}
