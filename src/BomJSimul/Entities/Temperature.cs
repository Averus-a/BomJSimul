namespace BomJSimul.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Temperature
    {
        /// <summary>
        /// Температура окружающей среды в градусах целсия (по умолчанию 20 градусов).
        /// </summary>
        public int C { get; set; } = 20; 

    }

    /// <summary>
    /// Уровень Воздействие Температуры на персонажа.
    /// </summary>
    internal enum ExposureToTemperature
    {
        Hot = 4,
        Warmly = 3,
        Normal = 2,
        Cool = 1,
        Coldly = 0,
    }
}
