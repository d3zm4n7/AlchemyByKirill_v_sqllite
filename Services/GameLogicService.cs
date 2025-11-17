// In Services/GameLogicService.cs

using AlchemyByKirill_v_sqllite.Models;
using Element = AlchemyByKirill_v_sqllite.Models.Element;
using System.Collections.Generic;
using System.Linq;

namespace AlchemyByKirill_v_sqllite.Services
{
    internal class GameLogicService
    {
        private List<Element> _allElements = new List<Element>();
        private List<Recipe> _allRecipes = new List<Recipe>();

        public GameLogicService()
        {
            LoadInitialData();
        }

        private void LoadInitialData()
        {
            _allElements = new List<Element>
            {
                // ID 1-4: Базовые элементы
                new Element(1, "Огонь", "fire.png", new Rect(50, 20, 75, 75)), // id1
                new Element(2, "Вода", "droplet.png", new Rect(150, 20, 75, 75)), // id2
                new Element(3, "Воздух", "wind_face.png", new Rect(50, 120, 75, 75)), // id3
                new Element(4, "Земля", "globe_showing_europe_africa.png", new Rect(150, 120, 75, 75)), // id4

                // --- ID 5-54: Создаваемые элементы ---

                // Геология и Атмосфера
                new Element(5, "Пар", "hot_springs.png", new Rect(0, 0, 75, 75)),
                new Element(6, "Лава", "volcano.png", new Rect(0, 0, 75, 75)),
                new Element(7, "Камень", "rock.png", new Rect(0, 0, 75, 75)),
                new Element(9, "Пыль", "dashing_away.png", new Rect(0, 0, 75, 75)),
                new Element(10, "Песок", "desert.png", new Rect(0, 0, 75, 75)),
                new Element(12, "Дождь", "cloud_with_rain.png", new Rect(0, 0, 75, 75)),
                new Element(13, "Металл", "nut_and_bolt.png", new Rect(0, 0, 75, 75)),
                new Element(14, "Глина", "pile_of_poo.png", new Rect(0, 0, 75, 75)),
                new Element(15, "Кирпич", "brick.png", new Rect(0, 0, 75, 75)),
                new Element(16, "Энергия", "high_voltage.png", new Rect(0, 0, 75, 75)),
                new Element(17, "Болото", "crocodile.png", new Rect(0, 0, 75, 75)),
                new Element(32, "Облако", "fog.png", new Rect(0, 0, 75, 75)),
                new Element(33, "Шторм", "cloud_with_lightning_and_rain.png", new Rect(0, 0, 75, 75)),
                new Element(54, "Волна", "water_wave.png", new Rect(0, 0, 75, 75)),

                // Биология
                new Element(8, "Растение", "seedling.png", new Rect(0, 0, 75, 75)),
                new Element(11, "Дерево", "evergreen_tree.png", new Rect(0, 0, 75, 75)),
                new Element(18, "Жизнь", "dna.png", new Rect(0, 0, 75, 75)),
                new Element(19, "Птица", "bird.png", new Rect(0, 0, 75, 75)),
                new Element(20, "Яйцо", "egg.png", new Rect(0, 0, 75, 75)),
                new Element(28, "Человек", "person.png", new Rect(0, 0, 75, 75)),
                new Element(34, "Зомби", "zombie.png", new Rect(0, 0, 75, 75)),
                new Element(35, "Труп", "skull.png", new Rect(0, 0, 75, 75)),
                new Element(37, "Рыба", "fish.png", new Rect(0, 0, 75, 75)),
                new Element(39, "Зверь", "wolf.png", new Rect(0, 0, 75, 75)),
                new Element(48, "Ящерица", "lizard.png", new Rect(0, 0, 75, 75)),
                new Element(49, "Дракон", "dragon_face.png", new Rect(0, 0, 75, 75)),

                // Цивилизация и Техника
                new Element(21, "Дом", "house.png", new Rect(0, 0, 75, 75)),
                new Element(22, "Деревня", "houses.png", new Rect(0, 0, 75, 75)),
                new Element(23, "Город", "cityscape.png", new Rect(0, 0, 75, 75)),
                new Element(24, "Инструмент", "wrench.png", new Rect(0, 0, 75, 75)),
                new Element(25, "Древесина", "wood.png", new Rect(0, 0, 75, 75)),
                new Element(26, "Лодка", "sailboat.png", new Rect(0, 0, 75, 75)),
                new Element(27, "Корабль", "ship.png", new Rect(0, 0, 75, 75)),
                new Element(29, "Фермер", "man.png", new Rect(0, 0, 75, 75)),
                new Element(30, "Пшеница", "sheaf_of_rice.png", new Rect(0, 0, 75, 75)),
                new Element(31, "Хлеб", "bread.png", new Rect(0, 0, 75, 75)),
                new Element(38, "Воин", "axe.png", new Rect(0, 0, 75, 75)),
                new Element(40, "Доктор", "pill.png", new Rect(0, 0, 75, 75)),
                new Element(41, "Ученый", "microscope.png", new Rect(0, 0, 75, 75)),
                new Element(50, "Компьютер", "laptop.png", new Rect(0, 0, 75, 75)),
                new Element(51, "Робот", "robot.png", new Rect(0, 0, 75, 75)),
                new Element(52, "Локомотив", "locomotive.png", new Rect(0, 0, 75, 75)),
                new Element(53, "Инструменты", "hammer.png", new Rect(0, 0, 75, 75)),

                // Космос
                new Element(36, "Остров", "desert_island.png", new Rect(0, 0, 75, 75)),
                new Element(42, "Ночь", "night_with_stars.png", new Rect(0, 0, 75, 75)),
                new Element(43, "Луна", "full_moon.png", new Rect(0, 0, 75, 75)),
                new Element(44, "Звезды", "milky_way.png", new Rect(0, 0, 75, 75)),
                new Element(45, "Космос", "ringed_planet.png", new Rect(0, 0, 75, 75)),
                new Element(46, "НЛО", "flying_saucer.png", new Rect(0, 0, 75, 75)),
                new Element(47, "Пришелец", "alien.png", new Rect(0, 0, 75, 75)),

                // Техника и Наука
                new Element(55, "Стекло", "gem_stone.png", new Rect(0, 0, 75, 75)),
                new Element(56, "Идея", "light_bulb.png", new Rect(0, 0, 75, 75)),
                new Element(61, "Самолет", "airplane.png", new Rect(0, 0, 75, 75)),
                new Element(62, "Ракета", "rocket.png", new Rect(0, 0, 75, 75)),
                new Element(63, "Космонавт", "astronaut.png", new Rect(0, 0, 75, 75)),
                new Element(72, "Бензин", "fuel_pump.png", new Rect(0, 0, 75, 75)),
                new Element(73, "Машина", "automobile.png", new Rect(0, 0, 75, 75)),
                new Element(85, "Взрыв", "collision.png", new Rect(0, 0, 75, 75)),
                new Element(95, "Химия", "test_tube.png", new Rect(0, 0, 75, 75)),
                new Element(96, "Цепь", "chains.png", new Rect(0, 0, 75, 75)),

                // Природа и Погода
                new Element(59, "Солнце", "sun.png", new Rect(0, 0, 75, 75)),
                new Element(60, "Радуга", "rainbow.png", new Rect(0, 0, 75, 75)),
                new Element(64, "Холод", "cold_face.png", new Rect(0, 0, 75, 75)),
                new Element(65, "Снег", "snowflake.png", new Rect(0, 0, 75, 75)),
                new Element(66, "Снеговик", "snowman_without_snow.png", new Rect(0, 0, 75, 75)),
                new Element(78, "Гора", "mountain.png", new Rect(0, 0, 75, 75)),
                new Element(81, "Лес", "deciduous_tree.png", new Rect(0, 0, 75, 75)),
                new Element(86, "Комета", "comet.png", new Rect(0, 0, 75, 75)),
                new Element(92, "Торнадо", "tornado.png", new Rect(0, 0, 75, 75)),
                new Element(93, "Ураган", "cyclone.png", new Rect(0, 0, 75, 75)),
                new Element(97, "Цветок", "sunflower.png", new Rect(0, 0, 75, 75)),

                // Биология (Продолжение)
                new Element(67, "Динозавр", "t_rex.png", new Rect(0, 0, 75, 75)),
                new Element(68, "Кость", "bone.png", new Rect(0, 0, 75, 75)),
                new Element(69, "Скелет", "skull.png", new Rect(0, 0, 75, 75)),
                new Element(70, "Ископаемое", "spiral_shell.png", new Rect(0, 0, 75, 75)),
                new Element(71, "Нефть", "oil_drum.png", new Rect(0, 0, 75, 75)),
                new Element(74, "Гриб", "mushroom.png", new Rect(0, 0, 75, 75)),
                new Element(75, "Лягушка", "frog.png", new Rect(0, 0, 75, 75)),
                new Element(79, "Орел", "eagle.png", new Rect(0, 0, 75, 75)),
                new Element(80, "Голубь", "dove.png", new Rect(0, 0, 75, 75)),
                new Element(84, "Яд", "skull_and_crossbones.png", new Rect(0, 0, 75, 75)),

                // Культура и Цивилизация (Продолжение)
                new Element(57, "Звук", "musical_note.png", new Rect(0, 0, 75, 75)),
                new Element(58, "Музыка", "musical_notes.png", new Rect(0, 0, 75, 75)),
                new Element(76, "Книга", "open_book.png", new Rect(0, 0, 75, 75)),
                new Element(77, "Ученик", "graduation_cap.png", new Rect(0, 0, 75, 75)),
                new Element(82, "Кемпинг", "camping.png", new Rect(0, 0, 75, 75)),
                new Element(83, "Еда", "bowl_with_spoon.png", new Rect(0, 0, 75, 75)),
                new Element(87, "Выпечка", "croissant.png", new Rect(0, 0, 75, 75)),
                new Element(94, "Карта", "world_map.png", new Rect(0, 0, 75, 75)),
                new Element(98, "Букет", "bouquet.png", new Rect(0, 0, 75, 75)),
                new Element(99, "Танцор", "man_dancing.png", new Rect(0, 0, 75, 75)),
                new Element(100, "Серфер", "person_surfing.png", new Rect(0, 0, 75, 75)),

                // Мифология и Абстракции
                new Element(88, "Тьма", "new_moon.png", new Rect(0, 0, 75, 75)),
                new Element(89, "Дьявол", "smiling_face_with_horns.png", new Rect(0, 0, 75, 75)),
                new Element(90, "Ангел", "baby_angel.png", new Rect(0, 0, 75, 75)),
                new Element(91, "Инь-Ян", "yin_yang.png", new Rect(0, 0, 75, 75))
            };

            _allRecipes = new List<Recipe>
            {
                // Базовые + Геология
                new Recipe(1, 2, 5),    // Огонь + Вода = Пар
                new Recipe(1, 4, 6),    // Огонь + Земля = Лава
                new Recipe(2, 4, 17),   // Вода + Земля = Болото
                new Recipe(3, 4, 9),    // Воздух + Земля = Пыль
                new Recipe(1, 3, 16),   // Огонь + Воздух = Энергия
                new Recipe(6, 2, 7),    // Лава + Вода = Камень
                new Recipe(2, 7, 10),   // Вода + Камень = Песок (ИЗМЕНЕНО: был Воздух + Камень)
                new Recipe(2, 9, 14),   // Вода + Пыль = Глина
                new Recipe(14, 1, 15),  // Глина + Огонь = Кирпич
                new Recipe(7, 1, 13),   // Камень + Огонь = Металл
    
                // Атмосфера
                new Recipe(5, 3, 32),   // Пар + Воздух = Облако
                new Recipe(32, 2, 12),  // Облако + Вода = Дождь
                new Recipe(2, 3, 54),   // Вода + Воздух = Волна
                new Recipe(54, 54, 33), // Волна + Волна = Шторм
                new Recipe(16, 32, 33), // Энергия + Облако = Шторм
    
                // Биология
                new Recipe(4, 12, 8),   // Земля + Дождь = Растение
                new Recipe(8, 4, 11),   // Растение + Земля = Дерево
                new Recipe(17, 16, 18), // Болото + Энергия = Жизнь
                new Recipe(18, 3, 19),  // Жизнь + Воздух = Птица
                new Recipe(18, 7, 20),  // Жизнь + Камень = Яйцо
                new Recipe(19, 19, 20), // Птица + Птица = Яйцо
                new Recipe(18, 4, 39),  // Жизнь + Земля = Зверь
                new Recipe(18, 10, 48), // Жизнь + Песок = Ящерица (ИЗМЕНЕНО: был Жизнь + Болото)
                new Recipe(48, 1, 49),  // Ящерица + Огонь = Дракон
                new Recipe(18, 2, 37),  // Жизнь + Вода = Рыба
    
                // Цивилизация
                new Recipe(18, 14, 28), // Жизнь + Глина = Человек
                new Recipe(7, 13, 53),  // Камень + Металл = Инструменты
                new Recipe(28, 53, 38), // Человек + Инструменты = Воин
                new Recipe(28, 13, 24), // Человек + Металл = Инструмент (Ключ)
                new Recipe(11, 24, 25), // Дерево + Инструмент = Древесина
                new Recipe(15, 15, 21), // Кирпич + Кирпич = Дом
                new Recipe(21, 21, 22), // Дом + Дом = Деревня
                new Recipe(22, 22, 23), // Деревня + Деревня = Город
                new Recipe(28, 4, 29),  // Человек + Земля = Фермер
                new Recipe(29, 8, 30),  // Фермер + Растение = Пшеница
                new Recipe(30, 1, 31),  // Пшеница + Огонь = Хлеб
                new Recipe(25, 2, 26),  // Древесина + Вода = Лодка
                new Recipe(26, 13, 27), // Лодка + Металл = Корабль
                new Recipe(27, 5, 52),  // Корабль + Пар = Локомотив
                new Recipe(4, 7, 36),   // Земля + Камень = Остров
                new Recipe(6, 2, 36),   // Лава(6) + Вода(2) = Остров(36) (дополнительно к Камню)

                // Смерть и Наука
                new Recipe(28, 1, 35),  // Человек + Огонь = Труп
                new Recipe(35, 18, 34), // Труп + Жизнь = Зомби
                new Recipe(28, 8, 40),  // Человек + Растение = Доктор
                new Recipe(28, 24, 41), // Человек + Инструмент = Ученый
                new Recipe(41, 13, 50), // Ученый + Металл = Компьютер
                new Recipe(18, 13, 51), // Жизнь + Металл = Робот
                new Recipe(50, 51, 47), // Компьютер + Робот = Пришелец (Логика?)

                // Космос
                new Recipe(3, 7, 43),   // Воздух + Камень = Луна (ОСТАВЛЕНО: теперь это уникальный рецепт)
                new Recipe(43, 3, 42),  // Луна + Воздух = Ночь
                new Recipe(42, 43, 44), // Ночь + Луна = Звезды
                new Recipe(44, 13, 45), // Звезды + Металл = Космос
                new Recipe(45, 27, 46), // Космос + Корабль = НЛО
                new Recipe(46, 18, 47), // НЛО + Жизнь = Пришелец

                // Техника и Наука
                new Recipe(10, 1, 55), // Песок + Огонь = Стекло
                new Recipe(28, 16, 56), // Человек + Энергия = Идея
                new Recipe(19, 13, 61), // Птица + Металл = Самолет
                new Recipe(61, 45, 62), // Самолет + Космос = Ракета
                new Recipe(28, 62, 63), // Человек + Ракета = Космонавт
                new Recipe(70, 2, 71), // Ископаемое + Вода = Нефть
                new Recipe(71, 1, 72), // Нефть + Огонь = Бензин
                new Recipe(13, 53, 73), // Металл + Инструменты = Машина
                new Recipe(16, 1, 85), // Энергия + Огонь = Взрыв
                new Recipe(41, 2, 95), // Ученый + Вода = Химия
                new Recipe(13, 13, 96), // Металл + Металл = Цепь

                // Природа и Погода
                new Recipe(1, 45, 59), // Огонь + Космос = Солнце
                new Recipe(12, 59, 60), // Дождь + Солнце = Радуга
                new Recipe(42, 3, 64), // Ночь + Воздух = Холод
                new Recipe(12, 64, 65), // Дождь + Холод = Снег
                new Recipe(65, 28, 66), // Снег + Человек = Снеговик
                new Recipe(7, 7, 78), // Камень + Камень = Гора
                new Recipe(11, 11, 81), // Дерево + Дерево = Лес
                new Recipe(7, 45, 86), // Камень + Космос = Комета
                new Recipe(33, 3, 92), // Шторм + Воздух = Торнадо
                new Recipe(92, 2, 93), // Торнадо + Вода = Ураган
                new Recipe(8, 59, 97), // Растение + Солнце = Цветок

                // Биология (Продолжение)
                new Recipe(48, 4, 67), // Ящерица + Земля = Динозавр
                new Recipe(35, 7, 68), // Труп + Камень = Кость
                new Recipe(68, 35, 69), // Кость + Труп = Скелет
                new Recipe(67, 7, 70), // Динозавр + Камень = Ископаемое
                new Recipe(8, 17, 74), // Растение + Болото = Гриб
                new Recipe(18, 17, 75), // Жизнь + Болото = Лягушка (ОСТАВЛЕНО: теперь это уникальный рецепт)
                new Recipe(19, 78, 79), // Птица + Гора = Орел
                new Recipe(19, 28, 80), // Птица + Человек = Голубь
                new Recipe(74, 24, 84), // Гриб + Инструмент = Яд

                // Культура и Цивилизация (Продолжение)
                new Recipe(3, 54, 57), // Воздух + Волна = Звук
                new Recipe(28, 57, 58), // Человек + Звук = Музыка
                new Recipe(25, 56, 76), // Древесина + Идея = Книга
                new Recipe(28, 76, 77), // Человек + Книга = Ученик
                new Recipe(77, 56, 41), // Ученик + Идея = Ученый (ID 41) (Альтернативный путь)
                new Recipe(81, 21, 82), // Лес + Дом = Кемпинг
                new Recipe(31, 2, 83), // Хлеб + Вода = Еда
                new Recipe(31, 1, 87), // Хлеб + Огонь = Выпечка
                new Recipe(76, 4, 94), // Книга + Земля = Карта
                new Recipe(97, 97, 98), // Цветок + Цветок = Букет
                new Recipe(28, 58, 99), // Человек + Музыка = Танцор
                new Recipe(28, 54, 100), // Человек + Волна = Серфер

                // Мифология и Абстракции
                new Recipe(42, 42, 88), // Ночь + Ночь = Тьма
                new Recipe(88, 18, 89), // Тьма + Жизнь = Дьявол
                new Recipe(18, 32, 90), // Жизнь + Облако = Ангел
                new Recipe(90, 89, 91) // Ангел + Дьявол = Инь-Ян
            };
        }

        public Element? GetElementById(int id)
        {
            return _allElements.FirstOrDefault(e => e.Id == id);
        }

        public List<Element> GetBaseElements()
        {
            var baseElements = _allElements.Where(e => e.Id >= 1 && e.Id <= 4).ToList();
            return baseElements.Select(e => new Element(e.Id, e.Name, e.ImagePath, e.Bounds)).ToList();
        }
        //для проверки картинок
        public List<Element> GetAllElements()
        {
            return _allElements.Select(e => new Element(e.Id, e.Name, e.ImagePath, e.Bounds)).ToList();
        }
        //для проверки картинок

        public Element? Combine(Element element1, Element element2)
        {
            if (element1 == null || element2 == null)
                return null;

            Recipe? foundRecipe = _allRecipes.FirstOrDefault(r => r.Matches(element1, element2));

            if (foundRecipe != null)
            {
                var resultPrototype = GetElementById(foundRecipe.ResultElementId);
                if (resultPrototype != null)
                {
                    return new Element(resultPrototype.Id, resultPrototype.Name, resultPrototype.ImagePath, resultPrototype.Bounds);
                }
            }

            return null;
        }

        public int CalculateScoreForDiscovery(Element discoveredElement)
        {
            return 1;
        }
    }
}