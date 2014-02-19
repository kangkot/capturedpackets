﻿//This file is part of the C# Packet Capture application. It is free and
//unencumbered software released into the public domain as detailed in
//the UNLICENSE file in the top level directory of this distribution

namespace PacketCaptureAnalyser
{
    partial class MainWindowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RunAnalysisOnSelectedPackageCaptureButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SelectedPacketCaptureForAnalysisDialog = new System.Windows.Forms.OpenFileDialog();
            this.SelectPacketCaptureButton = new System.Windows.Forms.Button();
            this.SelectedPacketCapturePathTextBox = new System.Windows.Forms.TextBox();
            this.SelectedPacketCapturePathLabel = new System.Windows.Forms.Label();
            this.SelectedPacketCaptureNameLabel = new System.Windows.Forms.Label();
            this.SelectedPacketCaptureNameTextBox = new System.Windows.Forms.TextBox();
            this.SelectedPacketCaptureTypeLabel = new System.Windows.Forms.Label();
            this.SelectedPacketCaptureTypeTextBox = new System.Windows.Forms.TextBox();
            this.ClearSelectedPacketCaptureButton = new System.Windows.Forms.Button();
            this.OpenSelectedPackageCaptureButton = new System.Windows.Forms.Button();
            this.PerformLatencyAnalysisCheckBox = new System.Windows.Forms.CheckBox();
            this.PerformTimeAnalysisCheckBox = new System.Windows.Forms.CheckBox();
            this.OutputLatencyAnalysisDebugCheckBox = new System.Windows.Forms.CheckBox();
            this.OutputTimeAnalysisDebugCheckBox = new System.Windows.Forms.CheckBox();
            this.MinimiseMemoryUsageCheckBox = new System.Windows.Forms.CheckBox();
            this.OutputDebugToOutputWindowCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // RunAnalysisOnSelectedPackageCaptureButton
            // 
            this.RunAnalysisOnSelectedPackageCaptureButton.Enabled = false;
            this.RunAnalysisOnSelectedPackageCaptureButton.Location = new System.Drawing.Point(12, 361);
            this.RunAnalysisOnSelectedPackageCaptureButton.Name = "RunAnalysisOnSelectedPackageCaptureButton";
            this.RunAnalysisOnSelectedPackageCaptureButton.Size = new System.Drawing.Size(340, 23);
            this.RunAnalysisOnSelectedPackageCaptureButton.TabIndex = 1;
            this.RunAnalysisOnSelectedPackageCaptureButton.Text = "Run Analysis On Selected Packet Capture";
            this.RunAnalysisOnSelectedPackageCaptureButton.UseVisualStyleBackColor = true;
            this.RunAnalysisOnSelectedPackageCaptureButton.Click += new System.EventHandler(this.RunAnalysisOnPacketCaptureButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(12, 390);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(340, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SelectedPacketCaptureForAnalysisDialog
            // 
            this.SelectedPacketCaptureForAnalysisDialog.Filter = "Packet Captures (*pcapng,*.pcap,*.libpcap,*.enc,*.cap,*.ntar)|*.pcapng;*.pcap;*.l" +
    "ibpcap;*.enc;*.cap;*.ntar";
            this.SelectedPacketCaptureForAnalysisDialog.Title = "Select Packet Capture For Analysis";
            // 
            // SelectPacketCaptureButton
            // 
            this.SelectPacketCaptureButton.Location = new System.Drawing.Point(12, 12);
            this.SelectPacketCaptureButton.Name = "SelectPacketCaptureButton";
            this.SelectPacketCaptureButton.Size = new System.Drawing.Size(340, 23);
            this.SelectPacketCaptureButton.TabIndex = 0;
            this.SelectPacketCaptureButton.Text = "Select Packet Capture";
            this.SelectPacketCaptureButton.UseVisualStyleBackColor = true;
            this.SelectPacketCaptureButton.Click += new System.EventHandler(this.SelectPacketCaptureForAnalysisButton_Click);
            // 
            // SelectedPacketCapturePathTextBox
            // 
            this.SelectedPacketCapturePathTextBox.Location = new System.Drawing.Point(12, 54);
            this.SelectedPacketCapturePathTextBox.Name = "SelectedPacketCapturePathTextBox";
            this.SelectedPacketCapturePathTextBox.ReadOnly = true;
            this.SelectedPacketCapturePathTextBox.Size = new System.Drawing.Size(340, 20);
            this.SelectedPacketCapturePathTextBox.TabIndex = 3;
            this.SelectedPacketCapturePathTextBox.TabStop = false;
            this.SelectedPacketCapturePathTextBox.Text = "<No Packet Capture Selected>";
            // 
            // SelectedPacketCapturePathLabel
            // 
            this.SelectedPacketCapturePathLabel.AutoSize = true;
            this.SelectedPacketCapturePathLabel.Location = new System.Drawing.Point(12, 38);
            this.SelectedPacketCapturePathLabel.Name = "SelectedPacketCapturePathLabel";
            this.SelectedPacketCapturePathLabel.Size = new System.Drawing.Size(168, 13);
            this.SelectedPacketCapturePathLabel.TabIndex = 4;
            this.SelectedPacketCapturePathLabel.Text = "Path Of Selected Packet Capture:";
            // 
            // SelectedPacketCaptureNameLabel
            // 
            this.SelectedPacketCaptureNameLabel.AutoSize = true;
            this.SelectedPacketCaptureNameLabel.Location = new System.Drawing.Point(12, 77);
            this.SelectedPacketCaptureNameLabel.Name = "SelectedPacketCaptureNameLabel";
            this.SelectedPacketCaptureNameLabel.Size = new System.Drawing.Size(174, 13);
            this.SelectedPacketCaptureNameLabel.TabIndex = 6;
            this.SelectedPacketCaptureNameLabel.Text = "Name Of Selected Packet Capture:";
            // 
            // SelectedPacketCaptureNameTextBox
            // 
            this.SelectedPacketCaptureNameTextBox.Location = new System.Drawing.Point(12, 93);
            this.SelectedPacketCaptureNameTextBox.Name = "SelectedPacketCaptureNameTextBox";
            this.SelectedPacketCaptureNameTextBox.ReadOnly = true;
            this.SelectedPacketCaptureNameTextBox.Size = new System.Drawing.Size(340, 20);
            this.SelectedPacketCaptureNameTextBox.TabIndex = 5;
            this.SelectedPacketCaptureNameTextBox.TabStop = false;
            this.SelectedPacketCaptureNameTextBox.Text = "<No Packet Capture Selected>";
            // 
            // SelectedPacketCaptureTypeLabel
            // 
            this.SelectedPacketCaptureTypeLabel.AutoSize = true;
            this.SelectedPacketCaptureTypeLabel.Location = new System.Drawing.Point(12, 116);
            this.SelectedPacketCaptureTypeLabel.Name = "SelectedPacketCaptureTypeLabel";
            this.SelectedPacketCaptureTypeLabel.Size = new System.Drawing.Size(170, 13);
            this.SelectedPacketCaptureTypeLabel.TabIndex = 8;
            this.SelectedPacketCaptureTypeLabel.Text = "Type Of Selected Packet Capture:";
            // 
            // SelectedPacketCaptureTypeTextBox
            // 
            this.SelectedPacketCaptureTypeTextBox.Location = new System.Drawing.Point(12, 132);
            this.SelectedPacketCaptureTypeTextBox.Name = "SelectedPacketCaptureTypeTextBox";
            this.SelectedPacketCaptureTypeTextBox.ReadOnly = true;
            this.SelectedPacketCaptureTypeTextBox.Size = new System.Drawing.Size(340, 20);
            this.SelectedPacketCaptureTypeTextBox.TabIndex = 7;
            this.SelectedPacketCaptureTypeTextBox.TabStop = false;
            this.SelectedPacketCaptureTypeTextBox.Text = "<No Packet Capture Selected>";
            // 
            // ClearSelectedPacketCaptureButton
            // 
            this.ClearSelectedPacketCaptureButton.Enabled = false;
            this.ClearSelectedPacketCaptureButton.Location = new System.Drawing.Point(12, 160);
            this.ClearSelectedPacketCaptureButton.Name = "ClearSelectedPacketCaptureButton";
            this.ClearSelectedPacketCaptureButton.Size = new System.Drawing.Size(340, 23);
            this.ClearSelectedPacketCaptureButton.TabIndex = 9;
            this.ClearSelectedPacketCaptureButton.Text = "Clear Selected Packet Capture";
            this.ClearSelectedPacketCaptureButton.UseVisualStyleBackColor = true;
            this.ClearSelectedPacketCaptureButton.Click += new System.EventHandler(this.ClearSelectedPacketCaptureButton_Click);
            // 
            // OpenSelectedPackageCaptureButton
            // 
            this.OpenSelectedPackageCaptureButton.Enabled = false;
            this.OpenSelectedPackageCaptureButton.Location = new System.Drawing.Point(12, 189);
            this.OpenSelectedPackageCaptureButton.Name = "OpenSelectedPackageCaptureButton";
            this.OpenSelectedPackageCaptureButton.Size = new System.Drawing.Size(340, 23);
            this.OpenSelectedPackageCaptureButton.TabIndex = 10;
            this.OpenSelectedPackageCaptureButton.Text = "Open Selected Packet Capture";
            this.OpenSelectedPackageCaptureButton.UseVisualStyleBackColor = true;
            this.OpenSelectedPackageCaptureButton.Click += new System.EventHandler(this.OpenSelectedPackageCaptureButton_Click);
            // 
            // PerformLatencyAnalysisCheckBox
            // 
            this.PerformLatencyAnalysisCheckBox.AutoSize = true;
            this.PerformLatencyAnalysisCheckBox.Checked = true;
            this.PerformLatencyAnalysisCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PerformLatencyAnalysisCheckBox.Enabled = false;
            this.PerformLatencyAnalysisCheckBox.Location = new System.Drawing.Point(12, 220);
            this.PerformLatencyAnalysisCheckBox.Name = "PerformLatencyAnalysisCheckBox";
            this.PerformLatencyAnalysisCheckBox.Size = new System.Drawing.Size(144, 17);
            this.PerformLatencyAnalysisCheckBox.TabIndex = 16;
            this.PerformLatencyAnalysisCheckBox.Text = "Perform Latency Analysis";
            this.PerformLatencyAnalysisCheckBox.UseVisualStyleBackColor = true;
            // 
            // PerformTimeAnalysisCheckBox
            // 
            this.PerformTimeAnalysisCheckBox.AutoSize = true;
            this.PerformTimeAnalysisCheckBox.Enabled = false;
            this.PerformTimeAnalysisCheckBox.Location = new System.Drawing.Point(12, 265);
            this.PerformTimeAnalysisCheckBox.Name = "PerformTimeAnalysisCheckBox";
            this.PerformTimeAnalysisCheckBox.Size = new System.Drawing.Size(129, 17);
            this.PerformTimeAnalysisCheckBox.TabIndex = 17;
            this.PerformTimeAnalysisCheckBox.Text = "Perform Time Analysis";
            this.PerformTimeAnalysisCheckBox.UseVisualStyleBackColor = true;
            // 
            // OutputLatencyAnalysisDebugCheckBox
            // 
            this.OutputLatencyAnalysisDebugCheckBox.AutoSize = true;
            this.OutputLatencyAnalysisDebugCheckBox.Enabled = false;
            this.OutputLatencyAnalysisDebugCheckBox.Location = new System.Drawing.Point(12, 242);
            this.OutputLatencyAnalysisDebugCheckBox.Name = "OutputLatencyAnalysisDebugCheckBox";
            this.OutputLatencyAnalysisDebugCheckBox.Size = new System.Drawing.Size(227, 17);
            this.OutputLatencyAnalysisDebugCheckBox.TabIndex = 18;
            this.OutputLatencyAnalysisDebugCheckBox.Text = "Output Latency Analysis Debug Infomation";
            this.OutputLatencyAnalysisDebugCheckBox.UseVisualStyleBackColor = true;
            this.OutputLatencyAnalysisDebugCheckBox.CheckedChanged += new System.EventHandler(this.OutputLatencyAnalysisDebugCheckBox_CheckedChanged);
            // 
            // OutputTimeAnalysisDebugCheckBox
            // 
            this.OutputTimeAnalysisDebugCheckBox.AutoSize = true;
            this.OutputTimeAnalysisDebugCheckBox.Enabled = false;
            this.OutputTimeAnalysisDebugCheckBox.Location = new System.Drawing.Point(12, 289);
            this.OutputTimeAnalysisDebugCheckBox.Name = "OutputTimeAnalysisDebugCheckBox";
            this.OutputTimeAnalysisDebugCheckBox.Size = new System.Drawing.Size(212, 17);
            this.OutputTimeAnalysisDebugCheckBox.TabIndex = 19;
            this.OutputTimeAnalysisDebugCheckBox.Text = "Output Time Analysis Debug Infomation";
            this.OutputTimeAnalysisDebugCheckBox.UseVisualStyleBackColor = true;
            this.OutputTimeAnalysisDebugCheckBox.CheckedChanged += new System.EventHandler(this.OutputTimeAnalysisDebugCheckBox_CheckedChanged);
            // 
            // MinimiseMemoryUsageCheckBox
            // 
            this.MinimiseMemoryUsageCheckBox.AutoSize = true;
            this.MinimiseMemoryUsageCheckBox.Enabled = false;
            this.MinimiseMemoryUsageCheckBox.Location = new System.Drawing.Point(12, 313);
            this.MinimiseMemoryUsageCheckBox.Name = "MinimiseMemoryUsageCheckBox";
            this.MinimiseMemoryUsageCheckBox.Size = new System.Drawing.Size(346, 17);
            this.MinimiseMemoryUsageCheckBox.TabIndex = 20;
            this.MinimiseMemoryUsageCheckBox.Text = "Minimise Memory Usage (Potentially Necessary For Very Large Files)";
            this.MinimiseMemoryUsageCheckBox.UseVisualStyleBackColor = true;
            // 
            // OutputDebugToOutputWindowCheckBox
            // 
            this.OutputDebugToOutputWindowCheckBox.AutoSize = true;
            this.OutputDebugToOutputWindowCheckBox.Enabled = false;
            this.OutputDebugToOutputWindowCheckBox.Location = new System.Drawing.Point(12, 337);
            this.OutputDebugToOutputWindowCheckBox.Name = "OutputDebugToOutputWindowCheckBox";
            this.OutputDebugToOutputWindowCheckBox.Size = new System.Drawing.Size(338, 17);
            this.OutputDebugToOutputWindowCheckBox.TabIndex = 21;
            this.OutputDebugToOutputWindowCheckBox.Text = "Output Debug To Output Window (Potentially Necessary On Error)";
            this.OutputDebugToOutputWindowCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 421);
            this.Controls.Add(this.OutputDebugToOutputWindowCheckBox);
            this.Controls.Add(this.MinimiseMemoryUsageCheckBox);
            this.Controls.Add(this.OutputTimeAnalysisDebugCheckBox);
            this.Controls.Add(this.OutputLatencyAnalysisDebugCheckBox);
            this.Controls.Add(this.PerformTimeAnalysisCheckBox);
            this.Controls.Add(this.PerformLatencyAnalysisCheckBox);
            this.Controls.Add(this.OpenSelectedPackageCaptureButton);
            this.Controls.Add(this.ClearSelectedPacketCaptureButton);
            this.Controls.Add(this.SelectedPacketCaptureTypeLabel);
            this.Controls.Add(this.SelectedPacketCaptureTypeTextBox);
            this.Controls.Add(this.SelectedPacketCaptureNameLabel);
            this.Controls.Add(this.SelectedPacketCaptureNameTextBox);
            this.Controls.Add(this.SelectedPacketCapturePathLabel);
            this.Controls.Add(this.SelectedPacketCapturePathTextBox);
            this.Controls.Add(this.SelectPacketCaptureButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RunAnalysisOnSelectedPackageCaptureButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainWindowForm";
            this.Text = "Packet Capture Analyser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RunAnalysisOnSelectedPackageCaptureButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.OpenFileDialog SelectedPacketCaptureForAnalysisDialog;
        private System.Windows.Forms.Button SelectPacketCaptureButton;
        private System.Windows.Forms.TextBox SelectedPacketCapturePathTextBox;
        private System.Windows.Forms.Label SelectedPacketCapturePathLabel;
        private System.Windows.Forms.Label SelectedPacketCaptureNameLabel;
        private System.Windows.Forms.TextBox SelectedPacketCaptureNameTextBox;
        private System.Windows.Forms.Label SelectedPacketCaptureTypeLabel;
        private System.Windows.Forms.TextBox SelectedPacketCaptureTypeTextBox;
        private System.Windows.Forms.Button ClearSelectedPacketCaptureButton;
        private System.Windows.Forms.Button OpenSelectedPackageCaptureButton;
        private System.Windows.Forms.CheckBox PerformLatencyAnalysisCheckBox;
        private System.Windows.Forms.CheckBox PerformTimeAnalysisCheckBox;
        private System.Windows.Forms.CheckBox OutputLatencyAnalysisDebugCheckBox;
        private System.Windows.Forms.CheckBox OutputTimeAnalysisDebugCheckBox;
        private System.Windows.Forms.CheckBox MinimiseMemoryUsageCheckBox;
        private System.Windows.Forms.CheckBox OutputDebugToOutputWindowCheckBox;
    }
}