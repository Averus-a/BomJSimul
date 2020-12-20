namespace BomJSimul.Gui.Consoles.GameViewContentConsole.Renderers
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using SadConsole;

    public class GameViewConentConsoleRenderer : SadConsole.Renderers.ControlsConsole
    {
        private readonly int _customSolidGlyph = 176;

        public override void Render(Console surface, bool force = false)
        {
            foreach (var cell in surface.RenderCells)
            {
                if (cell.Glyph == 0)
                {
                    cell.Glyph = _customSolidGlyph;
                }
            }

            base.Render(surface, force);
        }

        protected override void RenderCells(SadConsole.Console surface, bool force = false)
        {
            if (surface.IsDirty || force)
            {
                if (surface.Tint.A != 255)
                {
                    if (surface.DefaultBackground.A != 0)
                    {
                        Global.SpriteBatch.Draw(surface.Font.FontImage, new Rectangle(0, 0, surface.AbsoluteArea.Width, surface.AbsoluteArea.Height), surface.Font.GlyphRects[surface.Font.SolidGlyphIndex], surface.DefaultBackground, 0f, Vector2.Zero, SpriteEffects.None, 0.2f);
                    }

                    for (int i = 0; i < surface.RenderCells.Length; i++)
                    {
                        ref Cell cell = ref surface.RenderCells[i];

                        if (!cell.IsVisible)
                        {
                            continue;
                        }

                        if (cell.Background != Color.Transparent && cell.Background != surface.DefaultBackground)
                        {
                            Global.SpriteBatch.Draw(surface.Font.FontImage, surface.RenderRects[i], surface.Font.GlyphRects[surface.Font.SolidGlyphIndex], cell.Background, 0f, Vector2.Zero, SpriteEffects.None, 0.3f);
                        }

                        if (cell.Foreground != Color.Transparent)
                        {
                            Global.SpriteBatch.Draw(surface.Font.FontImage, surface.RenderRects[i], surface.Font.GlyphRects[cell.Glyph], cell.Foreground, 0f, Vector2.Zero, cell.Mirror, 0.4f);
                        }

                        foreach (CellDecorator decorator in cell.Decorators)
                        {
                            if (decorator.Color != Color.Transparent)
                            {
                                Global.SpriteBatch.Draw(surface.Font.FontImage, surface.RenderRects[i], surface.Font.GlyphRects[decorator.Glyph], decorator.Color, 0f, Vector2.Zero, decorator.Mirror, 0.5f);
                            }
                        }
                    }
                }
            }
        }
    }
}
