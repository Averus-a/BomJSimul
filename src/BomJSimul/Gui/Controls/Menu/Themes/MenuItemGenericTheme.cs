namespace BomJSimul.Gui.Sad.Themes
{
    using System;
    using Microsoft.Xna.Framework;
    using SadConsole;
    using SadConsole.Controls;
    using SadConsole.Themes;

    public class MenuItemGenericTheme : ButtonTheme
    {
        public MenuItemGenericTheme()
        {
            ShowEnds = false;
        }

        public override ThemeBase Clone()
        {
            return new MenuItemGenericTheme()
            {
                Normal = Normal.Clone(),
                Disabled = Disabled.Clone(),
                MouseOver = MouseOver.Clone(),
                MouseDown = MouseDown.Clone(),
                Selected = Selected.Clone(),
                Focused = Focused.Clone(),
                ShowEnds = ShowEnds,
                EndCharacterLeft = EndCharacterLeft,
                EndCharacterRight = EndCharacterRight
            };
        }

        public override void Attached(ControlBase control)
        {
            base.Attached(control);
        }

        public override void UpdateAndDraw(ControlBase control, TimeSpan time)
        {
            if (!(control is MenuItem button))
            {
                return;
            }

            if (!button.IsDirty)
            {
                return;
            }

            RefreshTheme(control.ThemeColors, control);
            Cell appearance = GetStateAppearance(control.State);

            // Redraw surface
            if (button.SizeToContent == SizeToContent.Stretch && !string.IsNullOrEmpty(button.Text))
            {
                var stretchedWidth = Math.Max(control.Width, button.Text.Length + 2);

                button.Surface = new CellSurface(stretchedWidth, control.Height)
                {
                    DefaultBackground = Color.Transparent
                };

                button.Surface.Clear();
            }

            int middle = button.Height != 1 ? button.Height / 2 : 0;

            // Redraw the control
            button.Surface.Fill(
                appearance.Foreground,
                appearance.Background,
                appearance.Glyph,
                null);

            if (ShowEnds && button.Width >= 3)
            {
                button.Surface.Print(1, middle, button.Text.Align(button.TextAlignment, button.Surface.Width - 2));
                button.Surface.SetGlyph(0, middle, EndCharacterLeft);
                button.Surface.SetGlyph(button.Surface.Width - 1, middle, EndCharacterRight);
            }
            else
            {
                button.Surface.Print(0, middle, button.Text.Align(button.TextAlignment, button.Surface.Width));
            }

            if ((control.State & (ControlStates.MouseOver | ControlStates.Clicked)) != 0)
            {
                button.Surface.SetGlyph(0, middle, 16);
                button.Surface.SetGlyph(button.Surface.Width - 1, middle, 17);
            }

            button.IsDirty = false;
        }
    }
}
