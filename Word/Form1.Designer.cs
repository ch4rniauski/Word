namespace Word
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            boldToolStripMenuItem = new ToolStripMenuItem();
            italicToolStripMenuItem = new ToolStripMenuItem();
            underlineToolStripMenuItem = new ToolStripMenuItem();
            paragraphToolStripMenuItem = new ToolStripMenuItem();
            alignLeftToolStripMenuItem = new ToolStripMenuItem();
            alignCenterToolStripMenuItem = new ToolStripMenuItem();
            alignRightToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
            increaseIndentToolStripMenuItem = new ToolStripMenuItem();
            decreaseIndentToolStripMenuItem = new ToolStripMenuItem();
            customIndentToolStripMenuItem = new ToolStripMenuItem();
            themeToolStripMenuItem = new ToolStripMenuItem();
            lightThemeToolStripMenuItem = new ToolStripMenuItem();
            darkThemeToolStripMenuItem = new ToolStripMenuItem();
            blueThemeToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButtonNew = new ToolStripButton();
            toolStripButtonOpen = new ToolStripButton();
            toolStripButtonSave = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripButtonBold = new ToolStripButton();
            toolStripButtonItalic = new ToolStripButton();
            toolStripButtonUnderline = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            toolStripButtonAlignLeft = new ToolStripButton();
            toolStripButtonAlignCenter = new ToolStripButton();
            toolStripButtonAlignRight = new ToolStripButton();
            toolStripSeparator9 = new ToolStripSeparator();
            toolStripComboBoxFont = new ToolStripComboBox();
            toolStripComboBoxFontSize = new ToolStripComboBox();
            richTextBox1 = new RichTextBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, formatToolStripMenuItem, paragraphToolStripMenuItem, themeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(933, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(48, 20);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = Properties.Resources.NewFileIcon;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(234, 22);
            newToolStripMenuItem.Text = "Создать";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = Properties.Resources.OpenFileIcon;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(234, 22);
            openToolStripMenuItem.Text = "Открыть...";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = Properties.Resources.SaveFileIcon;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(234, 22);
            saveToolStripMenuItem.Text = "Сохранить";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Image = Properties.Resources.SaveFileAsIcon;
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            saveAsToolStripMenuItem.Size = new Size(234, 22);
            saveAsToolStripMenuItem.Text = "Сохранить как...";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(231, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = Properties.Resources.ExitIcon;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Size = new Size(234, 22);
            exitToolStripMenuItem.Text = "Выход";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, toolStripSeparator2, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator3, selectAllToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(59, 20);
            editToolStripMenuItem.Text = "Правка";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(190, 22);
            undoToolStripMenuItem.Text = "Отменить";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(187, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Image = Properties.Resources.CutIcon;
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(190, 22);
            cutToolStripMenuItem.Text = "Вырезать";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Image = Properties.Resources.CopyIcon;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(190, 22);
            copyToolStripMenuItem.Text = "Копировать";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Image = Properties.Resources.PasteIcon;
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(190, 22);
            pasteToolStripMenuItem.Text = "Вставить";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(187, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            selectAllToolStripMenuItem.Size = new Size(190, 22);
            selectAllToolStripMenuItem.Text = "Выделить все";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem, colorToolStripMenuItem, toolStripSeparator4, boldToolStripMenuItem, italicToolStripMenuItem, underlineToolStripMenuItem });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(62, 20);
            formatToolStripMenuItem.Text = "Формат";
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Image = Properties.Resources.FontsIcon;
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(198, 22);
            fontToolStripMenuItem.Text = "Шрифт...";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(198, 22);
            colorToolStripMenuItem.Text = "Цвет текста...";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(195, 6);
            // 
            // boldToolStripMenuItem
            // 
            boldToolStripMenuItem.Image = Properties.Resources.BoldTextIcon;
            boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            boldToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.B;
            boldToolStripMenuItem.Size = new Size(198, 22);
            boldToolStripMenuItem.Text = "Жирный";
            boldToolStripMenuItem.Click += boldToolStripMenuItem_Click1;
            // 
            // italicToolStripMenuItem
            // 
            italicToolStripMenuItem.Image = Properties.Resources.ItalicTextIcon;
            italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            italicToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.I;
            italicToolStripMenuItem.Size = new Size(198, 22);
            italicToolStripMenuItem.Text = "Курсив";
            italicToolStripMenuItem.Click += italicToolStripMenuItem_Click;
            // 
            // underlineToolStripMenuItem
            // 
            underlineToolStripMenuItem.Image = Properties.Resources.UnderlineTextIcon;
            underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            underlineToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.U;
            underlineToolStripMenuItem.Size = new Size(198, 22);
            underlineToolStripMenuItem.Text = "Подчеркнутый";
            underlineToolStripMenuItem.Click += underlineToolStripMenuItem_Click;
            // 
            // paragraphToolStripMenuItem
            // 
            paragraphToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alignLeftToolStripMenuItem, alignCenterToolStripMenuItem, alignRightToolStripMenuItem, toolStripSeparator7, increaseIndentToolStripMenuItem, decreaseIndentToolStripMenuItem, customIndentToolStripMenuItem });
            paragraphToolStripMenuItem.Name = "paragraphToolStripMenuItem";
            paragraphToolStripMenuItem.Size = new Size(52, 20);
            paragraphToolStripMenuItem.Text = "Абзац";
            // 
            // alignLeftToolStripMenuItem
            // 
            alignLeftToolStripMenuItem.Name = "alignLeftToolStripMenuItem";
            alignLeftToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            alignLeftToolStripMenuItem.Size = new Size(275, 22);
            alignLeftToolStripMenuItem.Text = "Выровнять по левому краю";
            alignLeftToolStripMenuItem.Click += alignLeftToolStripMenuItem_Click;
            // 
            // alignCenterToolStripMenuItem
            // 
            alignCenterToolStripMenuItem.Name = "alignCenterToolStripMenuItem";
            alignCenterToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            alignCenterToolStripMenuItem.Size = new Size(275, 22);
            alignCenterToolStripMenuItem.Text = "Выровнять по центру";
            alignCenterToolStripMenuItem.Click += alignCenterToolStripMenuItem_Click;
            // 
            // alignRightToolStripMenuItem
            // 
            alignRightToolStripMenuItem.Name = "alignRightToolStripMenuItem";
            alignRightToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            alignRightToolStripMenuItem.Size = new Size(275, 22);
            alignRightToolStripMenuItem.Text = "Выровнять по правому краю";
            alignRightToolStripMenuItem.Click += alignRightToolStripMenuItem_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(272, 6);
            // 
            // increaseIndentToolStripMenuItem
            // 
            increaseIndentToolStripMenuItem.Name = "increaseIndentToolStripMenuItem";
            increaseIndentToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Tab;
            increaseIndentToolStripMenuItem.Size = new Size(275, 22);
            increaseIndentToolStripMenuItem.Text = "Увеличить отступ";
            increaseIndentToolStripMenuItem.Click += increaseIndentToolStripMenuItem_Click;
            // 
            // decreaseIndentToolStripMenuItem
            // 
            decreaseIndentToolStripMenuItem.Name = "decreaseIndentToolStripMenuItem";
            decreaseIndentToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.Tab;
            decreaseIndentToolStripMenuItem.Size = new Size(275, 22);
            decreaseIndentToolStripMenuItem.Text = "Уменьшить отступ";
            decreaseIndentToolStripMenuItem.Click += decreaseIndentToolStripMenuItem_Click;
            // 
            // customIndentToolStripMenuItem
            // 
            customIndentToolStripMenuItem.Name = "customIndentToolStripMenuItem";
            customIndentToolStripMenuItem.Size = new Size(275, 22);
            customIndentToolStripMenuItem.Text = "Пользовательский отступ...";
            customIndentToolStripMenuItem.Click += customIndentToolStripMenuItem_Click;
            // 
            // themeToolStripMenuItem
            // 
            themeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lightThemeToolStripMenuItem, darkThemeToolStripMenuItem, blueThemeToolStripMenuItem });
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.Size = new Size(50, 20);
            themeToolStripMenuItem.Text = "Темы";
            // 
            // lightThemeToolStripMenuItem
            // 
            lightThemeToolStripMenuItem.Name = "lightThemeToolStripMenuItem";
            lightThemeToolStripMenuItem.Size = new Size(147, 22);
            lightThemeToolStripMenuItem.Text = "Светлая тема";
            lightThemeToolStripMenuItem.Click += lightThemeToolStripMenuItem_Click;
            // 
            // darkThemeToolStripMenuItem
            // 
            darkThemeToolStripMenuItem.Name = "darkThemeToolStripMenuItem";
            darkThemeToolStripMenuItem.Size = new Size(147, 22);
            darkThemeToolStripMenuItem.Text = "Темная тема";
            darkThemeToolStripMenuItem.Click += darkThemeToolStripMenuItem_Click;
            // 
            // blueThemeToolStripMenuItem
            // 
            blueThemeToolStripMenuItem.Name = "blueThemeToolStripMenuItem";
            blueThemeToolStripMenuItem.Size = new Size(147, 22);
            blueThemeToolStripMenuItem.Text = "Синяя тема";
            blueThemeToolStripMenuItem.Click += blueThemeToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonNew, toolStripButtonOpen, toolStripButtonSave, toolStripSeparator5, toolStripButtonBold, toolStripButtonItalic, toolStripButtonUnderline, toolStripSeparator6, toolStripButtonAlignLeft, toolStripButtonAlignCenter, toolStripButtonAlignRight, toolStripSeparator9, toolStripComboBoxFont, toolStripComboBoxFontSize });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(933, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNew
            // 
            toolStripButtonNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonNew.Image = Properties.Resources.NewFileIcon;
            toolStripButtonNew.ImageTransparentColor = Color.Magenta;
            toolStripButtonNew.Name = "toolStripButtonNew";
            toolStripButtonNew.Size = new Size(23, 22);
            toolStripButtonNew.Text = "Создать";
            toolStripButtonNew.Click += toolStripButtonNew_Click;
            // 
            // toolStripButtonOpen
            // 
            toolStripButtonOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonOpen.Image = Properties.Resources.OpenFileIcon;
            toolStripButtonOpen.ImageTransparentColor = Color.Magenta;
            toolStripButtonOpen.Name = "toolStripButtonOpen";
            toolStripButtonOpen.Size = new Size(23, 22);
            toolStripButtonOpen.Text = "Открыть";
            toolStripButtonOpen.Click += toolStripButtonOpen_Click;
            // 
            // toolStripButtonSave
            // 
            toolStripButtonSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSave.Image = Properties.Resources.SaveFileIcon;
            toolStripButtonSave.ImageTransparentColor = Color.Magenta;
            toolStripButtonSave.Name = "toolStripButtonSave";
            toolStripButtonSave.Size = new Size(23, 22);
            toolStripButtonSave.Text = "Сохранить";
            toolStripButtonSave.Click += toolStripButtonSave_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 25);
            // 
            // toolStripButtonBold
            // 
            toolStripButtonBold.CheckOnClick = true;
            toolStripButtonBold.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            toolStripButtonBold.Name = "toolStripButtonBold";
            toolStripButtonBold.Size = new Size(23, 22);
            toolStripButtonBold.Text = "B";
            toolStripButtonBold.ToolTipText = "Жирный текст";
            toolStripButtonBold.Click += toolStripButtonBold_Click;
            // 
            // toolStripButtonItalic
            // 
            toolStripButtonItalic.CheckOnClick = true;
            toolStripButtonItalic.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonItalic.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            toolStripButtonItalic.Name = "toolStripButtonItalic";
            toolStripButtonItalic.Size = new Size(23, 22);
            toolStripButtonItalic.Text = "I";
            toolStripButtonItalic.ToolTipText = "Курсивный текст";
            toolStripButtonItalic.Click += toolStripButtonItalic_Click;
            // 
            // toolStripButtonUnderline
            // 
            toolStripButtonUnderline.CheckOnClick = true;
            toolStripButtonUnderline.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonUnderline.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            toolStripButtonUnderline.Name = "toolStripButtonUnderline";
            toolStripButtonUnderline.Size = new Size(23, 22);
            toolStripButtonUnderline.Text = "U";
            toolStripButtonUnderline.ToolTipText = "Подчеркнутый текст";
            toolStripButtonUnderline.Click += toolStripButtonUnderline_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 25);
            // 
            // toolStripButtonAlignLeft
            // 
            toolStripButtonAlignLeft.CheckOnClick = true;
            toolStripButtonAlignLeft.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonAlignLeft.Image = Properties.Resources.AlignLeft;
            toolStripButtonAlignLeft.ImageTransparentColor = Color.Magenta;
            toolStripButtonAlignLeft.Name = "toolStripButtonAlignLeft";
            toolStripButtonAlignLeft.Size = new Size(23, 22);
            toolStripButtonAlignLeft.ToolTipText = "Выровнять по левому краю";
            toolStripButtonAlignLeft.Click += toolStripButtonAlignLeft_Click;
            // 
            // toolStripButtonAlignCenter
            // 
            toolStripButtonAlignCenter.CheckOnClick = true;
            toolStripButtonAlignCenter.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonAlignCenter.Image = Properties.Resources.AlignCenter;
            toolStripButtonAlignCenter.ImageTransparentColor = Color.Magenta;
            toolStripButtonAlignCenter.Name = "toolStripButtonAlignCenter";
            toolStripButtonAlignCenter.Size = new Size(23, 22);
            toolStripButtonAlignCenter.ToolTipText = "Выровнять по центру";
            toolStripButtonAlignCenter.Click += toolStripButtonAlignCenter_Click;
            // 
            // toolStripButtonAlignRight
            // 
            toolStripButtonAlignRight.CheckOnClick = true;
            toolStripButtonAlignRight.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonAlignRight.Image = Properties.Resources.AlignRight;
            toolStripButtonAlignRight.ImageTransparentColor = Color.Magenta;
            toolStripButtonAlignRight.Name = "toolStripButtonAlignRight";
            toolStripButtonAlignRight.Size = new Size(23, 22);
            toolStripButtonAlignRight.ToolTipText = "Выровнять по правому краю";
            toolStripButtonAlignRight.Click += toolStripButtonAlignRight_Click;
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new Size(6, 25);
            // 
            // toolStripComboBoxFont
            // 
            toolStripComboBoxFont.Name = "toolStripComboBoxFont";
            toolStripComboBoxFont.Size = new Size(140, 25);
            toolStripComboBoxFont.SelectedIndexChanged += toolStripComboBoxFont_SelectedIndexChanged;
            // 
            // toolStripComboBoxFontSize
            // 
            toolStripComboBoxFontSize.Name = "toolStripComboBoxFontSize";
            toolStripComboBoxFontSize.Size = new Size(87, 25);
            toolStripComboBoxFontSize.SelectedIndexChanged += toolStripComboBoxFontSize_SelectedIndexChanged;
            toolStripComboBoxFontSize.KeyDown += toolStripComboBoxFontSize_KeyDown;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 49);
            richTextBox1.Margin = new Padding(4, 3, 4, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(933, 439);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.SelectionChanged += richTextBox1_SelectionChanged;
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip1.Location = new Point(0, 488);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(933, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(45, 17);
            toolStripStatusLabel.Text = "Готово";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 510);
            Controls.Add(richTextBox1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(450, 300);
            Name = "Form1";
            Text = "Текстовый редактор";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonNew;
        private ToolStripButton toolStripButtonOpen;
        private RichTextBox richTextBox1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem boldToolStripMenuItem;
        private ToolStripMenuItem italicToolStripMenuItem;
        private ToolStripMenuItem underlineToolStripMenuItem;
        private ToolStripMenuItem lightThemeToolStripMenuItem;
        private ToolStripMenuItem darkThemeToolStripMenuItem;
        private ToolStripMenuItem blueThemeToolStripMenuItem;
        private ToolStripButton toolStripButtonSave;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton toolStripButtonBold;
        private ToolStripButton toolStripButtonItalic;
        private ToolStripButton toolStripButtonUnderline;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripComboBox toolStripComboBoxFont;
        private ToolStripComboBox toolStripComboBoxFontSize;
        private ToolStripMenuItem paragraphToolStripMenuItem;
        private ToolStripMenuItem alignLeftToolStripMenuItem;
        private ToolStripMenuItem alignCenterToolStripMenuItem;
        private ToolStripMenuItem alignRightToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem increaseIndentToolStripMenuItem;
        private ToolStripMenuItem decreaseIndentToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripButton toolStripButtonAlignLeft;
        private ToolStripButton toolStripButtonAlignCenter;
        private ToolStripButton toolStripButtonAlignRight;
        private ToolStripMenuItem customIndentToolStripMenuItem;
    }
}
