namespace BomJSimul
{
    using Microsoft.Xna.Framework;

    public static class ConsoleExtensions
    {
        public static void DrawBorders(this SadConsole.Console console, int width, int height, Color foreground, Color background)
        {
            // 179 - vertical line
            // 186 - horizontal line
            console.DrawLine(new Point(0, 0), new Point(0, height), foreground, background, 179); // Left side
            console.DrawLine(new Point(width - 1, 0), new Point(width - 1, height - 1), foreground, background, 179); // Right side

            console.DrawLine(new Point(0, 0), new Point(width, 0), foreground, background, 196);
            console.DrawLine(new Point(0, height - 1), new Point(width - 1, height - 1), foreground, background, 196);

            // Angles
            console.SetGlyph(0, 0, 218); // Left-top
            console.SetGlyph(width - 1, 0, 191); // Right-top
            console.SetGlyph(0, height - 1, 192); // Left-bottom
            console.SetGlyph(width - 1, height - 1, 217); // Right-bottom
        }
    }
}
