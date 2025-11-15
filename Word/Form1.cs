using System.Globalization;
using Word.Classes;

namespace Word;

public partial class Form1 : Form
{
    private bool _isDirty = false;
    private string _currentFilePath = string.Empty;
    private bool _isSessionEnding = false;
    private bool _isOperationInProgress = false;
    private ColorTheme _currentTheme = ColorTheme.LightTheme;

    public Form1()
    {
        InitializeComponent();
        Microsoft.Win32.SystemEvents.SessionEnding += SystemEvents_SessionEnding;
    }

    private void toolStripButtonBold_Click(object sender, EventArgs e)
    {
        if (richTextBox1.SelectionFont is not null)
        {
            var currentFont = richTextBox1.SelectionFont;
            FontStyle newStyle;

            if (currentFont.Bold)
            {
                // Убираем жирный стиль, сохраняя остальные
                newStyle = currentFont.Style & ~FontStyle.Bold;
                toolStripButtonBold.Checked = false;
            }
            else
            {
                // Добавляем жирный стиль к существующим
                newStyle = currentFont.Style | FontStyle.Bold;
                toolStripButtonBold.Checked = true;
            }

            richTextBox1.SelectionFont = new Font(currentFont, newStyle);
            richTextBox1.Focus(); // Восстанавливаем фокус
        }
    }

    private void boldToolStripMenuItem_Click1(object sender, EventArgs e)
    {
        toolStripButtonBold_Click(sender, e);
        boldToolStripMenuItem.Checked = toolStripButtonBold.Checked;
    }

    private void toolStripButtonItalic_Click(object sender, EventArgs e)
    {
        if (richTextBox1.SelectionFont is not null)
        {
            var currentFont = richTextBox1.SelectionFont;
            FontStyle newStyle;

            if (currentFont.Italic)
            {
                newStyle = currentFont.Style & ~FontStyle.Italic;
                toolStripButtonItalic.Checked = false;
            }
            else
            {
                newStyle = currentFont.Style | FontStyle.Italic;
                toolStripButtonItalic.Checked = true;
            }

            richTextBox1.SelectionFont = new Font(currentFont, newStyle);
            richTextBox1.Focus();
        }
    }

    private void italicToolStripMenuItem_Click(object sender, EventArgs e)
    {
        toolStripButtonItalic_Click(sender, e);
        italicToolStripMenuItem.Checked = toolStripButtonItalic.Checked;
    }

    private void toolStripButtonUnderline_Click(object sender, EventArgs e)
    {
        if (richTextBox1.SelectionFont is not null)
        {
            var currentFont = richTextBox1.SelectionFont;
            FontStyle newStyle;

            if (currentFont.Underline)
            {
                newStyle = currentFont.Style & ~FontStyle.Underline;
                toolStripButtonUnderline.Checked = false;
            }
            else
            {
                newStyle = currentFont.Style | FontStyle.Underline;
                toolStripButtonUnderline.Checked = true;
            }

            richTextBox1.SelectionFont = new Font(currentFont, newStyle);
            richTextBox1.Focus();
        }
    }

    private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
    {
        toolStripButtonUnderline_Click(sender, e);
        underlineToolStripMenuItem.Checked = toolStripButtonUnderline.Checked;
    }

    private void richTextBox1_SelectionChanged(object sender, EventArgs e)
    {
        if (richTextBox1.SelectionFont is not null)
        {
            // Обновление состояния кнопок форматирования
            toolStripButtonBold.Checked = richTextBox1.SelectionFont.Bold;
            toolStripButtonItalic.Checked = richTextBox1.SelectionFont.Italic;
            toolStripButtonUnderline.Checked = richTextBox1.SelectionFont.Underline;

            // Обновление ComboBox для выбора шрифта
            toolStripComboBoxFont.Text = richTextBox1.SelectionFont.FontFamily.Name;

            // Обновление ComboBox для размера шрифта
            toolStripComboBoxFontSize.Text = richTextBox1.SelectionFont.Size.ToString(CultureInfo.InvariantCulture);

            // Обновляем кнопки выравнивания
            UpdateAlignmentButtons(richTextBox1.SelectionAlignment);
        }
    }

    private void toolStripComboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (richTextBox1.SelectionFont is not null
            && toolStripComboBoxFont.SelectedItem is not null)
        {
            try
            {
                var fontName = toolStripComboBoxFont.SelectedItem.ToString()!;
                var currentFont = richTextBox1.SelectionFont;

                richTextBox1.SelectionFont = new Font(fontName, currentFont.Size, currentFont.Style);
                richTextBox1.Focus();
            }
            catch
            {
                MessageBox.Show(
                    text: @"Ошибка при применении шрифта",
                    caption: @"Ошибка",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error);
            }
        }
    }

    private void toolStripComboBoxFontSize_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (richTextBox1.SelectionFont is not null
            && toolStripComboBoxFontSize.SelectedItem is not null)
        {
            try
            {
                if (float.TryParse(toolStripComboBoxFontSize.SelectedItem.ToString(), out var fontSize))
                {
                    var currentFont = richTextBox1.SelectionFont;
                    richTextBox1.SelectionFont = new Font(currentFont.FontFamily, fontSize, currentFont.Style);
                    richTextBox1.Focus();
                }
            }
            catch
            {
                MessageBox.Show(
                    text: @"Ошибка при применении размера шрифта",
                    caption: @"Ошибка",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error);
            }
        }
    }

    private void fontToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var fontDialog = new FontDialog();

        fontDialog.Font = richTextBox1.SelectionFont
                          ?? richTextBox1.Font;

        if (fontDialog.ShowDialog() == DialogResult.OK)
        {
            richTextBox1.SelectionFont = fontDialog.Font;
            richTextBox1.Focus();
            _isDirty = true;
            UpdateTitle();
        }
    }

    private void colorToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var colorDialog = new ColorDialog();

        if (richTextBox1.SelectionColor != Color.Empty)
        {
            colorDialog.Color = richTextBox1.SelectionColor;
        }

        if (colorDialog.ShowDialog() == DialogResult.OK)
        {
            richTextBox1.SelectionColor = colorDialog.Color;
            richTextBox1.Focus();
            _isDirty = true;
            UpdateTitle();
        }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        // Инициализация ComboBox для выбора шрифта
        foreach (var font in FontFamily.Families)
        {
            toolStripComboBoxFont.Items.Add(font.Name);
        }
        toolStripComboBoxFont.Text = @"Segoe UI";

        // Инициализация ComboBox для выбора размера шрифта
        int[] sizes = [8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72];
        foreach (var size in sizes)
        {
            toolStripComboBoxFontSize.Items.Add(size.ToString());
        }
        toolStripComboBoxFontSize.Text = @"12";

        // Загружаем сохраненные настройки
        LoadSettings();
    }

    private void richTextBox1_TextChanged(object sender, EventArgs e)
    {
        _isDirty = true;
        UpdateTitle();
    }

    private void UpdateTitle()
    {
        var fileName = string.IsNullOrEmpty(_currentFilePath)
            ? "Безымянный"
            : Path.GetFileName(_currentFilePath);

        Text = $@"{fileName}{(_isDirty ? "*" : "")} - Текстовый редактор";
    }

    private void LoadSettings()
    {
        try
        {
            // Восстанавливаем размер и позицию окна
            var width = Properties.Settings.Default.WindowWidth;
            var height = Properties.Settings.Default.WindowHeight;
            var left = Properties.Settings.Default.WindowLeft;
            var top = Properties.Settings.Default.WindowTop;

            // Проверяем, что окно будет видимо на экране
            var currentScreen = Screen.FromPoint(new Point(left, top));
            var windowRect = new Rectangle(left, top, width, height);
            if (currentScreen.WorkingArea.Contains(windowRect))
            {
                StartPosition = FormStartPosition.Manual;
                Width = width;
                Height = height;
                Left = left;
                Top = top;
            }

            // Восстанавливаем состояние окна
            var windowState = Properties.Settings.Default.WindowState;
            if (!string.IsNullOrEmpty(windowState))
            {
                WindowState = Enum.Parse<FormWindowState>(windowState);
            }

            // Восстанавливаем тему
            var themeName = Properties.Settings.Default.SelectedTheme;
            var theme = themeName switch
            {
                "Темная тема" => ColorTheme.DarkTheme,
                "Синяя тема" => ColorTheme.BlueTheme,
                _ => ColorTheme.LightTheme
            };
            ApplyTheme(theme);

            // Установим галочки у текущей темы в меню
            UpdateThemeMenuCheckmarks(theme.Name);

            // Восстанавливаем шрифт по умолчанию
            var fontName = Properties.Settings.Default.DefaultFontName;
            var fontSize = Properties.Settings.Default.DefaultFontSize;

            if (!string.IsNullOrEmpty(fontName))
            {
                try
                {
                    richTextBox1.Font = new Font(fontName, fontSize);
                }
                catch
                {
                    // Используем шрифт по умолчанию если указанный недоступен
                }
            }

            // Предлагаем открыть последний файл
            var lastFile = Properties.Settings.Default.LastOpenedFile;
            if (!string.IsNullOrEmpty(lastFile)
                && File.Exists(lastFile))
            {
                var result = MessageBox.Show(
                    text: $"""
                           Открыть последний редактируемый файл?
                           {Path.GetFileName(lastFile)}
                           """,
                    caption: @"Восстановление сеанса",
                    buttons: MessageBoxButtons.YesNo,
                    icon: MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    LoadDocument(lastFile);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                text: $"""
                       Ошибка при восстановлении настроек:
                       {ex.Message}
                       Будут использованы настройки по умолчанию.
                       """,
                caption: @"Предупреждение",
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Warning);
        }
    }

    private void UpdateThemeMenuCheckmarks(string themeName)
    {
        lightThemeToolStripMenuItem.Checked = themeName == "Светлая тема";
        darkThemeToolStripMenuItem.Checked = themeName == "Темная тема";
        blueThemeToolStripMenuItem.Checked = themeName == "Синяя тема";
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (_isSessionEnding)
        {
            // Разрешить быстрое закрытие при завершении сеанса
            return;
        }

        if (_isOperationInProgress)
        {
            MessageBox.Show(
                text: @"Операция выполняется. Пожалуйста, дождитесь ее завершения.",
                caption: @"Операция в процессе",
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Information);
            e.Cancel = true;
            return;
        }

        if (_isDirty)
        {
            var result = MessageBox.Show(
                text: @"Документ был изменен. Сохранить изменения?",
                caption: @"Подтверждение закрытия",
                buttons: MessageBoxButtons.YesNoCancel,
                icon: MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    if (!SaveDocument())
                    {
                        e.Cancel = true; // Отменить закрытие если сохранение не удалось
                    }
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true; // Отменить закрытие
                    break;
                case DialogResult.No:
                    // Закрыть без сохранения
                    break;
            }
        }

        if (!e.Cancel)
        {
            SaveSettings();
        }
    }

    private void SaveSettings()
    {
        // Сохраняем размер и позицию окна только если оно не свернуто/развернуто
        if (WindowState == FormWindowState.Normal)
        {
            Properties.Settings.Default.WindowWidth = Width;
            Properties.Settings.Default.WindowHeight = Height;
            Properties.Settings.Default.WindowLeft = Left;
            Properties.Settings.Default.WindowTop = Top;
        }

        Properties.Settings.Default.WindowState = WindowState.ToString();
        Properties.Settings.Default.SelectedTheme = _currentTheme.Name;

        if (!string.IsNullOrEmpty(_currentFilePath))
        {
            Properties.Settings.Default.LastOpenedFile = _currentFilePath;
        }

        // Сохраняем настройки шрифта по умолчанию
        var defaultFont = richTextBox1.Font;
        Properties.Settings.Default.DefaultFontName = defaultFont.FontFamily.Name;
        Properties.Settings.Default.DefaultFontSize = defaultFont.Size;

        Properties.Settings.Default.Save();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        => Close();

    private void SystemEvents_SessionEnding(object sender, Microsoft.Win32.SessionEndingEventArgs e)
    {
        _isSessionEnding = true;

        // Автоматическое сохранение без диалога
        if (_isDirty && !string.IsNullOrEmpty(_currentFilePath))
        {
            try
            {
                richTextBox1.SaveFile(_currentFilePath, RichTextBoxStreamType.RichText);
            }
            catch
            {
                // Не показываем ошибку при завершении сеанса
            }
        }

        Close();
    }

    private bool CheckSaveDocument()
    {
        if (_isDirty)
        {
            var result = MessageBox.Show(
                text: @"Сохранить изменения в текущем документе?",
                caption: @"Несохраненные изменения",
                buttons: MessageBoxButtons.YesNoCancel,
                icon: MessageBoxIcon.Warning);

            return result switch
            {
                DialogResult.Yes => SaveDocument(),
                DialogResult.No => true,
                DialogResult.Cancel => false,
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        return true;
    }

    private void toolStripButtonOpen_Click(object sender, EventArgs e)
        => openToolStripMenuItem_Click(sender, e);

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!CheckSaveDocument())
        {
            return; // Пользователь отменил операцию
        }

        var openDialog = new OpenFileDialog()
        {
            Filter = @"RTF файлы (*.rtf)|*.rtf|Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
            Title = @"Открыть документ",
            CheckFileExists = true,
            CheckPathExists = true
        };

        if (openDialog.ShowDialog() == DialogResult.OK)
        {
            LoadDocument(openDialog.FileName);
        }
    }

    private void toolStripButtonNew_Click(object sender, EventArgs e)
        => newToolStripMenuItem_Click(sender, e);

    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!CheckSaveDocument())
        {
            return;
        }

        richTextBox1.Clear();
        _currentFilePath = string.Empty;
        _isDirty = false;
        UpdateTitle();
        toolStripStatusLabel.Text = @"Создан новый документ";
    }

    private void LoadDocument(string filePath)
    {
        try
        {
            // Проверка существования файла
            if (!File.Exists(filePath))
            {
                MessageBox.Show(
                    text: $"""
                           Файл не найден:
                           {filePath}
                           """,
                    caption: @"Ошибка загрузки",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error);
                return;
            }

            // Проверка расширения файла
            var extension = Path.GetExtension(filePath).ToLower();
            RichTextBoxStreamType streamType;

            switch (extension)
            {
                case ".rtf":
                    streamType = RichTextBoxStreamType.RichText;
                    break;
                case ".txt":
                    streamType = RichTextBoxStreamType.PlainText;
                    break;
                default:
                    var result = MessageBox.Show(
                        text: $"""
                               Файл имеет неподдерживаемое расширение: {extension}
                               Попробовать открыть как обычный текст?
                               """,
                        caption: @"Предупреждение",
                        buttons: MessageBoxButtons.YesNo,
                        icon: MessageBoxIcon.Warning);

                    if (result == DialogResult.No)
                    {
                        return;
                    }
                    streamType = RichTextBoxStreamType.PlainText;
                    break;
            }

            richTextBox1.LoadFile(filePath, streamType);
            _currentFilePath = filePath;
            _isDirty = false;
            UpdateTitle();
            toolStripStatusLabel.Text = $@"Файл загружен: {Path.GetFileName(filePath)}";
        }
        catch (IOException ex)
        {
            MessageBox.Show(
                text: $"""
                       Ошибка при чтении файла:
                       {ex.Message}
                       """,
                caption: @"Ошибка ввода-вывода",
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Error);
            toolStripStatusLabel.Text = @"Ошибка загрузки файла";
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(
                text: $"""
                       Файл имеет неверный формат или поврежден:
                       {ex.Message}
                       """,
                caption: @"Ошибка формата",
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Error);
            toolStripStatusLabel.Text = @"Ошибка формата файла";
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                text: $"""
                       Неожиданная ошибка при загрузке файла:
                       {ex.Message}
                       """,
                caption: @"Ошибка",
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Error);
            toolStripStatusLabel.Text = @"Ошибка загрузки";
        }
    }

    private bool SaveDocument()
    {
        if (string.IsNullOrEmpty(_currentFilePath))
        {
            return SaveDocumentAs();
        }

        try
        {
            _isOperationInProgress = true;

            // Определяем тип сохранения по расширению
            var extension = Path.GetExtension(_currentFilePath).ToLower();
            var streamType = extension == ".txt"
                ? RichTextBoxStreamType.PlainText
                : RichTextBoxStreamType.RichText;

            richTextBox1.SaveFile(_currentFilePath, streamType);
            _isDirty = false;
            UpdateTitle();
            toolStripStatusLabel.Text = $@"Файл сохранен: {Path.GetFileName(_currentFilePath)}";
            return true;
        }
        catch (UnauthorizedAccessException)
        {
            MessageBox.Show(
                text: """
                      Недостаточно прав для сохранения файла в этом месте.
                      Выберите другое место для сохранения.
                      """,
                caption: @"Ошибка доступа",
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Error);
            return SaveDocumentAs();
        }
        catch (IOException ex)
        {
            var result = MessageBox.Show(
                text: $"""
                       Ошибка при сохранении файла:{ex.Message}
                       Попробовать сохранить в другое место?
                       """,
                caption: @"Ошибка сохранения",
                buttons: MessageBoxButtons.YesNo,
                icon: MessageBoxIcon.Error);

            if (result == DialogResult.Yes)
            {
                return SaveDocumentAs();
            }
            toolStripStatusLabel.Text = @"Ошибка сохранения";
            return false;
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                text: $"""
                       Неожиданная ошибка при сохранении:
                       {ex.Message}
                       """,
                caption: @"Ошибка",
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Error);
            toolStripStatusLabel.Text = @"Ошибка сохранения";
            return false;
        }
        finally
        {
            _isOperationInProgress = false;
        }
    }

    private bool SaveDocumentAs()
    {
        var saveDialog = new SaveFileDialog
        {
            Filter = @"RTF файлы (*.rtf)|*.rtf|Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
            Title = @"Сохранить документ как",
            CheckPathExists = true,
            AddExtension = true,
            DefaultExt = "rtf"
        };

        if (!string.IsNullOrEmpty(_currentFilePath))
        {
            saveDialog.FileName = Path.GetFileName(_currentFilePath);
            saveDialog.InitialDirectory = Path.GetDirectoryName(_currentFilePath);
        }

        if (saveDialog.ShowDialog() != DialogResult.OK)
        {
            return false;
        }
        
        _currentFilePath = saveDialog.FileName;
        return SaveDocument();

    }

    private void toolStripButtonSave_Click(object sender, EventArgs e)
        => saveToolStripMenuItem_Click(sender, e);

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        => SaveDocument();

    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        => SaveDocumentAs();

    private void undoToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (richTextBox1.CanUndo)
        {
            richTextBox1.Undo();
        }
    }

    private void cutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (richTextBox1.SelectionLength > 0)
        {
            richTextBox1.Cut();
        }
    }

    private void copyToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (richTextBox1.SelectionLength > 0)
        {
            richTextBox1.Copy();
        }
    }

    private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        => richTextBox1.Paste();

    private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        => richTextBox1.SelectAll();

    private void ApplyTheme(ColorTheme theme)
    {
        _currentTheme = theme;

        try
        {
            // Применяем цвета к форме
            BackColor = theme.FormBackColor;
            ForeColor = theme.FormForeColor;

            // Применяем к MenuStrip
            menuStrip1.BackColor = theme.MenuBackColor;
            menuStrip1.ForeColor = theme.MenuForeColor;
            ApplyThemeToMenuItems(menuStrip1.Items, theme);

            // Применяем к ToolStrip
            toolStrip1.BackColor = theme.ToolStripBackColor;
            toolStrip1.ForeColor = theme.ToolStripForeColor;
            ApplyThemeToToolStripItems(toolStrip1.Items, theme);

            // Применяем ТОЛЬКО фон к RichTextBox, не трогая ForeColor
            richTextBox1.BackColor = theme.RichTextBoxBackColor;

            // Применяем к StatusStrip
            statusStrip1.BackColor = theme.StatusStripBackColor;
            statusStrip1.ForeColor = theme.StatusStripForeColor;
            ApplyThemeToStatusStripItems(statusStrip1.Items, theme);

            // Сохраняем выбор темы в настройки
            Properties.Settings.Default.SelectedTheme = theme.Name;
            Properties.Settings.Default.Save();

            toolStripStatusLabel.Text = $@"Применена тема: {theme.Name}";
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                text: $"""
                       Ошибка при применении темы:
                       {ex.Message}
                       """,
                caption: @"Ошибка",
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Error);
            toolStripStatusLabel.Text = @"Ошибка применения темы";
        }
    }

    private static void ApplyThemeToMenuItems(ToolStripItemCollection items, ColorTheme theme)
    {
        foreach (ToolStripItem item in items)
        {
            item.BackColor = theme.MenuBackColor;
            item.ForeColor = theme.MenuForeColor;

            if (item is ToolStripMenuItem menuItem
                && menuItem.HasDropDownItems)
            {
                ApplyThemeToMenuItems(menuItem.DropDownItems, theme);
            }
        }
    }

    private static void ApplyThemeToToolStripItems(ToolStripItemCollection items, ColorTheme theme)
    {
        foreach (ToolStripItem item in items)
        {
            item.BackColor = theme.ToolStripBackColor;
            item.ForeColor = theme.ToolStripForeColor;
        }
    }

    private static void ApplyThemeToStatusStripItems(ToolStripItemCollection items, ColorTheme theme)
    {
        foreach (ToolStripItem item in items)
        {
            item.BackColor = theme.StatusStripBackColor;
            item.ForeColor = theme.StatusStripForeColor;
        }
    }

    private void lightThemeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ApplyTheme(ColorTheme.LightTheme);

        lightThemeToolStripMenuItem.Checked = true;
        darkThemeToolStripMenuItem.Checked = false;
        blueThemeToolStripMenuItem.Checked = false;
    }

    private void darkThemeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ApplyTheme(ColorTheme.DarkTheme);

        lightThemeToolStripMenuItem.Checked = false;
        darkThemeToolStripMenuItem.Checked = true;
        blueThemeToolStripMenuItem.Checked = false;
    }

    private void blueThemeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ApplyTheme(ColorTheme.BlueTheme);

        lightThemeToolStripMenuItem.Checked = false;
        darkThemeToolStripMenuItem.Checked = false;
        blueThemeToolStripMenuItem.Checked = true;
    }

    private void alignLeftToolStripMenuItem_Click(object sender, EventArgs e)
    {
        richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        UpdateAlignmentButtons(HorizontalAlignment.Left);
        _isDirty = true;
        UpdateTitle();
    }

    private void alignCenterToolStripMenuItem_Click(object sender, EventArgs e)
    {
        richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        UpdateAlignmentButtons(HorizontalAlignment.Center);
        _isDirty = true;
        UpdateTitle();
    }

    private void alignRightToolStripMenuItem_Click(object sender, EventArgs e)
    {
        richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        UpdateAlignmentButtons(HorizontalAlignment.Right);
        _isDirty = true;
        UpdateTitle();
    }

    private void increaseIndentToolStripMenuItem_Click(object sender, EventArgs e)
    {
        richTextBox1.SelectionIndent += 20;
        _isDirty = true;
        UpdateTitle();
    }

    private void decreaseIndentToolStripMenuItem_Click(object sender, EventArgs e)
    {
        richTextBox1.SelectionIndent = Math.Max(0, richTextBox1.SelectionIndent - 20);
        _isDirty = true;
        UpdateTitle();
    }

    private void toolStripButtonAlignLeft_Click(object sender, EventArgs e)
        => alignLeftToolStripMenuItem_Click(sender, e);

    private void toolStripButtonAlignCenter_Click(object sender, EventArgs e)
        => alignCenterToolStripMenuItem_Click(sender, e);

    private void toolStripButtonAlignRight_Click(object sender, EventArgs e)
        => alignRightToolStripMenuItem_Click(sender, e);

    private void UpdateAlignmentButtons(HorizontalAlignment alignment)
    {
        toolStripButtonAlignLeft.Checked = alignment == HorizontalAlignment.Left;
        toolStripButtonAlignCenter.Checked = alignment == HorizontalAlignment.Center;
        toolStripButtonAlignRight.Checked = alignment == HorizontalAlignment.Right;

        alignLeftToolStripMenuItem.Checked = alignment == HorizontalAlignment.Left;
        alignCenterToolStripMenuItem.Checked = alignment == HorizontalAlignment.Center;
        alignRightToolStripMenuItem.Checked = alignment == HorizontalAlignment.Right;
    }

    private void customIndentToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var indentDialog = new IndentDialog(richTextBox1.SelectionIndent);

        if (indentDialog.ShowDialog(this) == DialogResult.OK)
        {
            richTextBox1.SelectionIndent = indentDialog.IndentValue;
            _isDirty = true;
            UpdateTitle();
            toolStripStatusLabel.Text = $@"Отступ установлен: {indentDialog.IndentValue} пиксели";
        }
    }
}