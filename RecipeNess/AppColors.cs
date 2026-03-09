using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeNess
{
    public static class AppColors
    {
        // Основной фон формы
        public static Color MainBackground = Color.FromArgb(250, 250, 245);

        // Фон для карточек, панелей, групбоксов
        public static Color PanelBackground = Color.FromArgb(235, 245, 230);

        // Основной текст (заголовки, названия)
        public static Color MainText = Color.FromArgb(50, 50, 45);

        // Второстепенный текст (подписи, дата, время)
        public static Color SecondaryText = Color.FromArgb(130, 140, 120);

        // Главный акцент (кнопки, важные ссылки)
        public static Color AccentOrange = Color.FromArgb(200, 100, 50);

        // Светлая версия главного акцента (для состояний наведения, рамок)
        public static Color AccentOrangeLight = Color.FromArgb(255, 200, 150);

        // Дополнительный акцент (например, для тегов, второстепенных кнопок)
        public static Color AccentGreen = Color.FromArgb(80, 140, 80);

        // Светлая версия зелёного (фон для выделенных элементов)
        public static Color AccentGreenLight = Color.FromArgb(200, 230, 200);

        // Разделители, границы
        public static Color Separator = Color.FromArgb(200, 200, 200);
    }
}
