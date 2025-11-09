namespace Word.Classes
{
    internal sealed class ColorTheme
    {
        public string Name { get; set; } = string.Empty;
        public Color FormBackColor { get; set; }
        public Color FormForeColor { get; set; }
        public Color MenuBackColor { get; set; }
        public Color MenuForeColor { get; set; }
        public Color ToolStripBackColor { get; set; }
        public Color ToolStripForeColor { get; set; }
        public Color RichTextBoxBackColor { get; set; }
        public Color RichTextBoxForeColor { get; set; }
        public Color StatusStripBackColor { get; set; }
        public Color StatusStripForeColor { get; set; }

        public static ColorTheme LightTheme => new()
        {
            Name = "Светлая тема",
            FormBackColor = Color.White,
            FormForeColor = Color.Black,
            MenuBackColor = Color.White,
            MenuForeColor = Color.Black,
            ToolStripBackColor = Color.FromArgb(240, 240, 240),
            ToolStripForeColor = Color.Black,
            RichTextBoxBackColor = Color.White,
            RichTextBoxForeColor = Color.Black,
            StatusStripBackColor = Color.FromArgb(240, 240, 240),
            StatusStripForeColor = Color.Black
        };

        public static ColorTheme DarkTheme => new()
        {
            Name = "Темная тема",
            FormBackColor = Color.FromArgb(45, 45, 48),
            FormForeColor = Color.White,
            MenuBackColor = Color.FromArgb(45, 45, 48),
            MenuForeColor = Color.White,
            ToolStripBackColor = Color.FromArgb(37, 37, 38),
            ToolStripForeColor = Color.White,
            RichTextBoxBackColor = Color.FromArgb(30, 30, 30),
            RichTextBoxForeColor = Color.White,
            StatusStripBackColor = Color.FromArgb(0, 122, 204),
            StatusStripForeColor = Color.White
        };

        public static ColorTheme BlueTheme => new()
        {
            Name = "Синяя тема",
            FormBackColor = Color.FromArgb(230, 240, 250),
            FormForeColor = Color.Black,
            MenuBackColor = Color.FromArgb(200, 220, 240),
            MenuForeColor = Color.Black,
            ToolStripBackColor = Color.FromArgb(180, 210, 240),
            ToolStripForeColor = Color.Black,
            RichTextBoxBackColor = Color.White,
            RichTextBoxForeColor = Color.Black,
            StatusStripBackColor = Color.FromArgb(0, 120, 215),
            StatusStripForeColor = Color.White
        };
    }
}
