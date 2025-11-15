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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            italicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            underlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lightThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            darkThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            blueThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            toolStripButtonBold = new System.Windows.Forms.ToolStripButton();
            toolStripButtonItalic = new System.Windows.Forms.ToolStripButton();
            toolStripButtonUnderline = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            toolStripComboBoxFont = new System.Windows.Forms.ToolStripComboBox();
            toolStripComboBoxFontSize = new System.Windows.Forms.ToolStripComboBox();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, formatToolStripMenuItem, themeToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(933, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = global::Word.Properties.Resources.NewFileIcon;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            newToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            newToolStripMenuItem.Text = "Создать";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = global::Word.Properties.Resources.OpenFileIcon;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
            openToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            openToolStripMenuItem.Text = "Открыть...";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = global::Word.Properties.Resources.SaveFileIcon;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            saveToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            saveToolStripMenuItem.Text = "Сохранить";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Image = global::Word.Properties.Resources.SaveFileAsIcon;
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) | System.Windows.Forms.Keys.S));
            saveAsToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            saveAsToolStripMenuItem.Text = "Сохранить как...";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = global::Word.Properties.Resources.ExitIcon;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4));
            exitToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            exitToolStripMenuItem.Text = "Выход";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { undoToolStripMenuItem, toolStripSeparator2, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator3, selectAllToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            editToolStripMenuItem.Text = "Правка";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z));
            undoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            undoToolStripMenuItem.Text = "Отменить";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(187, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Image = global::Word.Properties.Resources.CutIcon;
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X));
            cutToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            cutToolStripMenuItem.Text = "Вырезать";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Image = global::Word.Properties.Resources.CopyIcon;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C));
            copyToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            copyToolStripMenuItem.Text = "Копировать";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Image = global::Word.Properties.Resources.PasteIcon;
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V));
            pasteToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            pasteToolStripMenuItem.Text = "Вставить";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(187, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A));
            selectAllToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            selectAllToolStripMenuItem.Text = "Выделить все";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { fontToolStripMenuItem, colorToolStripMenuItem, toolStripSeparator4, boldToolStripMenuItem, italicToolStripMenuItem, underlineToolStripMenuItem });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            formatToolStripMenuItem.Text = "Формат";
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Image = global::Word.Properties.Resources.FontsIcon;
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            fontToolStripMenuItem.Text = "Шрифт...";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            colorToolStripMenuItem.Text = "Цвет текста...";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(195, 6);
            // 
            // boldToolStripMenuItem
            // 
            boldToolStripMenuItem.Image = global::Word.Properties.Resources.BoldTextIcon;
            boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            boldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B));
            boldToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            boldToolStripMenuItem.Text = "Жирный";
            boldToolStripMenuItem.Click += boldToolStripMenuItem_Click1;
            // 
            // italicToolStripMenuItem
            // 
            italicToolStripMenuItem.Image = global::Word.Properties.Resources.ItalicTextIcon;
            italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            italicToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I));
            italicToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            italicToolStripMenuItem.Text = "Курсив";
            italicToolStripMenuItem.Click += italicToolStripMenuItem_Click;
            // 
            // underlineToolStripMenuItem
            // 
            underlineToolStripMenuItem.Image = global::Word.Properties.Resources.UnderlineTextIcon;
            underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            underlineToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U));
            underlineToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            underlineToolStripMenuItem.Text = "Подчеркнутый";
            underlineToolStripMenuItem.Click += underlineToolStripMenuItem_Click;
            // 
            // themeToolStripMenuItem
            // 
            themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { lightThemeToolStripMenuItem, darkThemeToolStripMenuItem, blueThemeToolStripMenuItem });
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            themeToolStripMenuItem.Text = "Темы";
            // 
            // lightThemeToolStripMenuItem
            // 
            lightThemeToolStripMenuItem.Name = "lightThemeToolStripMenuItem";
            lightThemeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            lightThemeToolStripMenuItem.Text = "Светлая тема";
            lightThemeToolStripMenuItem.Click += lightThemeToolStripMenuItem_Click;
            // 
            // darkThemeToolStripMenuItem
            // 
            darkThemeToolStripMenuItem.Name = "darkThemeToolStripMenuItem";
            darkThemeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            darkThemeToolStripMenuItem.Text = "Темная тема";
            darkThemeToolStripMenuItem.Click += darkThemeToolStripMenuItem_Click;
            // 
            // blueThemeToolStripMenuItem
            // 
            blueThemeToolStripMenuItem.Name = "blueThemeToolStripMenuItem";
            blueThemeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            blueThemeToolStripMenuItem.Text = "Синяя тема";
            blueThemeToolStripMenuItem.Click += blueThemeToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripButtonNew, toolStripButtonOpen, toolStripButtonSave, toolStripSeparator5, toolStripButtonBold, toolStripButtonItalic, toolStripButtonUnderline, toolStripSeparator6, toolStripComboBoxFont, toolStripComboBoxFontSize });
            toolStrip1.Location = new System.Drawing.Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(933, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNew
            // 
            toolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButtonNew.Image = global::Word.Properties.Resources.NewFileIcon;
            toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonNew.Name = "toolStripButtonNew";
            toolStripButtonNew.Size = new System.Drawing.Size(23, 22);
            toolStripButtonNew.Text = "Создать";
            toolStripButtonNew.Click += toolStripButtonNew_Click;
            // 
            // toolStripButtonOpen
            // 
            toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButtonOpen.Image = global::Word.Properties.Resources.OpenFileIcon;
            toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonOpen.Name = "toolStripButtonOpen";
            toolStripButtonOpen.Size = new System.Drawing.Size(23, 22);
            toolStripButtonOpen.Text = "Открыть";
            toolStripButtonOpen.Click += toolStripButtonOpen_Click;
            // 
            // toolStripButtonSave
            // 
            toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButtonSave.Image = global::Word.Properties.Resources.SaveFileIcon;
            toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonSave.Name = "toolStripButtonSave";
            toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            toolStripButtonSave.Text = "Сохранить";
            toolStripButtonSave.Click += toolStripButtonSave_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonBold
            // 
            toolStripButtonBold.CheckOnClick = true;
            toolStripButtonBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripButtonBold.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            toolStripButtonBold.Name = "toolStripButtonBold";
            toolStripButtonBold.Size = new System.Drawing.Size(23, 22);
            toolStripButtonBold.Text = "B";
            toolStripButtonBold.ToolTipText = "Жирный текст";
            toolStripButtonBold.Click += toolStripButtonBold_Click;
            // 
            // toolStripButtonItalic
            // 
            toolStripButtonItalic.CheckOnClick = true;
            toolStripButtonItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripButtonItalic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            toolStripButtonItalic.Name = "toolStripButtonItalic";
            toolStripButtonItalic.Size = new System.Drawing.Size(23, 22);
            toolStripButtonItalic.Text = "I";
            toolStripButtonItalic.ToolTipText = "Курсивный текст";
            toolStripButtonItalic.Click += toolStripButtonItalic_Click;
            // 
            // toolStripButtonUnderline
            // 
            toolStripButtonUnderline.CheckOnClick = true;
            toolStripButtonUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripButtonUnderline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            toolStripButtonUnderline.Name = "toolStripButtonUnderline";
            toolStripButtonUnderline.Size = new System.Drawing.Size(23, 22);
            toolStripButtonUnderline.Text = "U";
            toolStripButtonUnderline.ToolTipText = "Подчеркнутый текст";
            toolStripButtonUnderline.Click += toolStripButtonUnderline_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripComboBoxFont
            // 
            toolStripComboBoxFont.Name = "toolStripComboBoxFont";
            toolStripComboBoxFont.Size = new System.Drawing.Size(140, 25);
            toolStripComboBoxFont.SelectedIndexChanged += toolStripComboBoxFont_SelectedIndexChanged;
            // 
            // toolStripComboBoxFontSize
            // 
            toolStripComboBoxFontSize.Name = "toolStripComboBoxFontSize";
            toolStripComboBoxFontSize.Size = new System.Drawing.Size(87, 25);
            toolStripComboBoxFontSize.SelectedIndexChanged += toolStripComboBoxFontSize_SelectedIndexChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            richTextBox1.Location = new System.Drawing.Point(0, 49);
            richTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(933, 439);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.SelectionChanged += richTextBox1_SelectionChanged;
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel });
            statusStrip1.Location = new System.Drawing.Point(0, 488);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStrip1.Size = new System.Drawing.Size(933, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new System.Drawing.Size(45, 17);
            toolStripStatusLabel.Text = "Готово";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 510);
            Controls.Add(richTextBox1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(450, 300);
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

        private MenuStrip menuStrip1;
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
    }
}
