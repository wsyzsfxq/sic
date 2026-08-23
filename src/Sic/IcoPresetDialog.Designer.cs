namespace Oire.Sic;

partial class IcoPresetDialog {
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent() {
        mainLayout = new TableLayoutPanel();
        presetGroupBox = new GroupBox();
        presetFlowLayout = new FlowLayoutPanel();
        faviconRadioButton = new RadioButton();
        appIconRadioButton = new RadioButton();
        customRadioButton = new RadioButton();
        sizesLabel = new Label();
        sizesListBox = new ListBox();
        addSizeButton = new Button();
        removeSizeButton = new Button();
        backgroundOptionsFlowLayout = new FlowLayoutPanel();
        removeBackgroundCheckBox = new CheckBox();
        backgroundToleranceLabel = new Label();
        backgroundToleranceNumericUpDown = new NumericUpDown();
        backgroundTolerancePercentLabel = new Label();
        okButton = new Button();
        cancelButton = new Button();

        mainLayout.SuspendLayout();
        presetGroupBox.SuspendLayout();
        presetFlowLayout.SuspendLayout();
        backgroundOptionsFlowLayout.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)backgroundToleranceNumericUpDown).BeginInit();
        SuspendLayout();

        //
        // mainLayout — 5 rows x 3 columns
        //
        mainLayout.ColumnCount = 3;
        mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        mainLayout.RowCount = 5;
        mainLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        mainLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        mainLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        mainLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        mainLayout.Dock = DockStyle.Fill;
        mainLayout.Padding = new Padding(12);
        mainLayout.Name = "mainLayout";

        // Row 0: Preset group box spanning all 3 columns
        mainLayout.Controls.Add(presetGroupBox, 0, 0);
        mainLayout.SetColumnSpan(presetGroupBox, 3);

        // Row 1: Sizes label, list box (rowspan 2), add button
        mainLayout.Controls.Add(sizesLabel, 0, 1);
        mainLayout.Controls.Add(sizesListBox, 1, 1);
        mainLayout.SetRowSpan(sizesListBox, 2);
        mainLayout.Controls.Add(addSizeButton, 2, 1);

        // Row 2: (empty col 0), (listbox continues), remove button
        mainLayout.Controls.Add(removeSizeButton, 2, 2);

        // Row 3: Solid-background transparency options spanning all 3 columns
        mainLayout.Controls.Add(backgroundOptionsFlowLayout, 0, 3);
        mainLayout.SetColumnSpan(backgroundOptionsFlowLayout, 3);

        // Row 4: OK button (col 0), cancel button (col 2)
        mainLayout.Controls.Add(okButton, 0, 4);
        mainLayout.Controls.Add(cancelButton, 2, 4);

        //
        // presetGroupBox
        //
        presetGroupBox.Text = "Pre&set:";
        presetGroupBox.AutoSize = true;
        presetGroupBox.Dock = DockStyle.Fill;
        presetGroupBox.Name = "presetGroupBox";
        presetGroupBox.TabIndex = 0;
        presetGroupBox.Controls.Add(presetFlowLayout);

        //
        // presetFlowLayout
        //
        presetFlowLayout.AutoSize = true;
        presetFlowLayout.Dock = DockStyle.Fill;
        presetFlowLayout.FlowDirection = FlowDirection.LeftToRight;
        presetFlowLayout.Name = "presetFlowLayout";
        presetFlowLayout.Controls.Add(faviconRadioButton);
        presetFlowLayout.Controls.Add(appIconRadioButton);
        presetFlowLayout.Controls.Add(customRadioButton);

        //
        // faviconRadioButton
        //
        faviconRadioButton.Text = "&Favicon";
        faviconRadioButton.AutoSize = true;
        faviconRadioButton.Name = "faviconRadioButton";
        faviconRadioButton.TabIndex = 0;

        //
        // appIconRadioButton
        //
        appIconRadioButton.Text = "Application &Icon";
        appIconRadioButton.AutoSize = true;
        appIconRadioButton.Checked = true;
        appIconRadioButton.Name = "appIconRadioButton";
        appIconRadioButton.TabIndex = 1;

        //
        // customRadioButton
        //
        customRadioButton.Text = "C&ustom";
        customRadioButton.AutoSize = true;
        customRadioButton.Name = "customRadioButton";
        customRadioButton.TabIndex = 2;

        //
        // sizesLabel
        //
        sizesLabel.Text = "Si&zes:";
        sizesLabel.AutoSize = true;
        sizesLabel.Anchor = AnchorStyles.Left | AnchorStyles.Top;
        sizesLabel.Name = "sizesLabel";
        sizesLabel.Enabled = false;
        sizesLabel.TabIndex = 3;

        //
        // sizesListBox
        //
        sizesListBox.Dock = DockStyle.Fill;
        sizesListBox.SelectionMode = SelectionMode.One;
        sizesListBox.Name = "sizesListBox";
        sizesListBox.Enabled = false;
        sizesListBox.TabIndex = 4;

        //
        // addSizeButton
        //
        addSizeButton.Text = "&Add...";
        addSizeButton.AutoSize = true;
        addSizeButton.Anchor = AnchorStyles.Left | AnchorStyles.Top;
        addSizeButton.Name = "addSizeButton";
        addSizeButton.Enabled = false;
        addSizeButton.TabIndex = 5;

        //
        // removeSizeButton
        //
        removeSizeButton.Text = "&Remove";
        removeSizeButton.AutoSize = true;
        removeSizeButton.Anchor = AnchorStyles.Left | AnchorStyles.Top;
        removeSizeButton.Name = "removeSizeButton";
        removeSizeButton.Enabled = false;
        removeSizeButton.TabIndex = 6;

        //
        // backgroundOptionsFlowLayout
        //
        backgroundOptionsFlowLayout.AutoSize = true;
        backgroundOptionsFlowLayout.Dock = DockStyle.Fill;
        backgroundOptionsFlowLayout.FlowDirection = FlowDirection.LeftToRight;
        backgroundOptionsFlowLayout.Margin = new Padding(0, 8, 0, 8);
        backgroundOptionsFlowLayout.Name = "backgroundOptionsFlowLayout";
        backgroundOptionsFlowLayout.Controls.Add(removeBackgroundCheckBox);
        backgroundOptionsFlowLayout.Controls.Add(backgroundToleranceLabel);
        backgroundOptionsFlowLayout.Controls.Add(backgroundToleranceNumericUpDown);
        backgroundOptionsFlowLayout.Controls.Add(backgroundTolerancePercentLabel);

        //
        // removeBackgroundCheckBox
        //
        removeBackgroundCheckBox.Text = "Make solid &background transparent (top-left color)";
        removeBackgroundCheckBox.AutoSize = true;
        removeBackgroundCheckBox.Name = "removeBackgroundCheckBox";
        removeBackgroundCheckBox.TabIndex = 7;

        //
        // backgroundToleranceLabel
        //
        backgroundToleranceLabel.Text = "&Tolerance:";
        backgroundToleranceLabel.AutoSize = true;
        backgroundToleranceLabel.Anchor = AnchorStyles.Left;
        backgroundToleranceLabel.Margin = new Padding(12, 6, 3, 0);
        backgroundToleranceLabel.Name = "backgroundToleranceLabel";
        backgroundToleranceLabel.TabIndex = 8;

        //
        // backgroundToleranceNumericUpDown
        //
        backgroundToleranceNumericUpDown.Minimum = 0;
        backgroundToleranceNumericUpDown.Maximum = 100;
        backgroundToleranceNumericUpDown.Value = 8;
        backgroundToleranceNumericUpDown.Width = 55;
        backgroundToleranceNumericUpDown.Name = "backgroundToleranceNumericUpDown";
        backgroundToleranceNumericUpDown.TabIndex = 9;

        //
        // backgroundTolerancePercentLabel
        //
        backgroundTolerancePercentLabel.Text = "%";
        backgroundTolerancePercentLabel.AutoSize = true;
        backgroundTolerancePercentLabel.Anchor = AnchorStyles.Left;
        backgroundTolerancePercentLabel.Margin = new Padding(0, 6, 3, 0);
        backgroundTolerancePercentLabel.Name = "backgroundTolerancePercentLabel";
        backgroundTolerancePercentLabel.TabIndex = 10;

        //
        // okButton
        //
        okButton.Text = "&OK";
        okButton.Dock = DockStyle.Fill;
        okButton.DialogResult = DialogResult.OK;
        okButton.Name = "okButton";
        okButton.TabIndex = 11;

        //
        // cancelButton
        //
        cancelButton.Text = "&Cancel";
        cancelButton.Dock = DockStyle.Fill;
        cancelButton.DialogResult = DialogResult.Cancel;
        cancelButton.Name = "cancelButton";
        cancelButton.TabIndex = 12;

        //
        // IcoPresetDialog
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(560, 365);
        Controls.Add(mainLayout);
        Name = "IcoPresetDialog";
        Text = "Create Multi-size ICO";
        FormBorderStyle = FormBorderStyle.FixedDialog;
        AccessibleRole = AccessibleRole.Dialog;
        StartPosition = FormStartPosition.CenterParent;
        MaximizeBox = false;
        MinimizeBox = false;
        AcceptButton = okButton;
        CancelButton = cancelButton;

        presetFlowLayout.ResumeLayout(false);
        presetFlowLayout.PerformLayout();
        presetGroupBox.ResumeLayout(false);
        presetGroupBox.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)backgroundToleranceNumericUpDown).EndInit();
        backgroundOptionsFlowLayout.ResumeLayout(false);
        backgroundOptionsFlowLayout.PerformLayout();
        mainLayout.ResumeLayout(false);
        mainLayout.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TableLayoutPanel mainLayout;
    private GroupBox presetGroupBox;
    private FlowLayoutPanel presetFlowLayout;
    private RadioButton faviconRadioButton;
    private RadioButton appIconRadioButton;
    private RadioButton customRadioButton;
    private Label sizesLabel;
    private ListBox sizesListBox;
    private Button addSizeButton;
    private Button removeSizeButton;
    private FlowLayoutPanel backgroundOptionsFlowLayout;
    private CheckBox removeBackgroundCheckBox;
    private Label backgroundToleranceLabel;
    private NumericUpDown backgroundToleranceNumericUpDown;
    private Label backgroundTolerancePercentLabel;
    private Button okButton;
    private Button cancelButton;
}
