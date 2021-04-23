using Microsoft.EntityFrameworkCore;
using System;
using WebUI.Models;
using WebUI.Models.Enums;

namespace WebUI.Data.Seeds
{
    internal static class CoateRecordSeed
    {
        private static DateTime _initialDate = new DateTime(1970, 1, 1);

        internal static ModelBuilder AddCoateSeedData(this ModelBuilder builder)
        {
            var coateRecords = new CoateRecord[]
            {
                new CoateRecord
                {
                    Id = 1, Name = "г. Бишкек", Code = "41711000000000", CoateType = CoateType.RegionAndCity,
                    ParentId = null, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2, Name = "г. Ош", Code = "41721000000000", CoateType = CoateType.RegionAndCity,
                    ParentId = null, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 3, Name = "Иссык-Кульская область", Code = "41702000000000",
                    CoateType = CoateType.RegionAndCity, ParentId = null, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 4, Name = "Джалал-Абадская область", Code = "41703000000000",
                    CoateType = CoateType.RegionAndCity, ParentId = null, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 5, Name = "Нарынская область", Code = "41704000000000", CoateType = CoateType.RegionAndCity,
                    ParentId = null, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 6, Name = "Баткенская область", Code = "41705000000000", CoateType = CoateType.RegionAndCity,
                    ParentId = null, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 7, Name = "Ошская область", Code = "41706000000000", CoateType = CoateType.RegionAndCity,
                    ParentId = null, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 8, Name = "Таласская область", Code = "41707000000000", CoateType = CoateType.RegionAndCity,
                    ParentId = null, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 9, Name = "Чуйская область", Code = "41708000000000", CoateType = CoateType.RegionAndCity,
                    ParentId = null, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 10, Name = "Ленинский район", Code = "41711201000000", CoateType = CoateType.District,
                    ParentId = 1, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 11, Name = "Октябрьский район", Code = "41711202000000", CoateType = CoateType.District,
                    ParentId = 1, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 12, Name = "Первомайский район", Code = "41711203000000", CoateType = CoateType.District,
                    ParentId = 1, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 13, Name = "Свердловский район", Code = "41711204000000", CoateType = CoateType.District,
                    ParentId = 1, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 14, Name = "Ак-Суйский район", Code = "41702205000000", CoateType = CoateType.District,
                    ParentId = 3, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 15, Name = "Жети-Огузский район", Code = "41702210000000", CoateType = CoateType.District,
                    ParentId = 3, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 16, Name = "Иссык-Кульский район", Code = "41702215000000", CoateType = CoateType.District,
                    ParentId = 3, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 17, Name = "Тонский районрайон", Code = "41702220000000", CoateType = CoateType.District,
                    ParentId = 3, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 18, Name = "Тюпский район", Code = "41702225000000", CoateType = CoateType.District,
                    ParentId = 3, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 19, Name = "г. Балыкчы", Code = "41702420000010", CoateType = CoateType.District, ParentId = 3,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 20, Name = "г. Каракол", Code = "41702410000010", CoateType = CoateType.District, ParentId = 3,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 21, Name = "Ала-Букинский район", Code = "41703204000000", CoateType = CoateType.District,
                    ParentId = 4, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 22, Name = "Базар-Коргонский район", Code = "41703207000000", CoateType = CoateType.District,
                    ParentId = 4, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 23, Name = "Аксыйский район", Code = "41703211000000", CoateType = CoateType.District,
                    ParentId = 4, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 24, Name = "Ноокенский район", Code = "41703215000000", CoateType = CoateType.District,
                    ParentId = 4, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 25, Name = "Сузакский район", Code = "41703220000000", CoateType = CoateType.District,
                    ParentId = 4, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 26, Name = "Тогуз-Тороуский район", Code = "41703223000000", CoateType = CoateType.District,
                    ParentId = 4, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 27, Name = "Токтогульский район", Code = "41703225000000", CoateType = CoateType.District,
                    ParentId = 4, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 28, Name = "Чаткальский район", Code = "41703230000000", CoateType = CoateType.District,
                    ParentId = 4, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 29, Name = "г. Джалал-Абад", Code = "41703410000010", CoateType = CoateType.District,
                    ParentId = 4, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 30, Name = "г. Таш-Кумыр", Code = "41703420000010", CoateType = CoateType.District,
                    ParentId = 4, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 31, Name = "г. Майлуу-Суу", Code = "41703430000010", CoateType = CoateType.District,
                    ParentId = 4, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 32, Name = "г. Кара-Куль", Code = "41703440000010", CoateType = CoateType.District,
                    ParentId = 4, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 33, Name = "Ак-Талинский район", Code = "41704210000000", CoateType = CoateType.District,
                    ParentId = 5, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 34, Name = "Ат-Башынский район", Code = "41704220000000", CoateType = CoateType.District,
                    ParentId = 5, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 35, Name = "Жумгальский район", Code = "41704230000000", CoateType = CoateType.District,
                    ParentId = 5, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 36, Name = "Кочкорский район", Code = "41704235000000", CoateType = CoateType.District,
                    ParentId = 5, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 37, Name = "Нарынский район", Code = "41704245000000", CoateType = CoateType.District,
                    ParentId = 5, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 38, Name = "г. Нарын", Code = "41704400000010", CoateType = CoateType.District, ParentId = 5,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 39, Name = "Баткенский район", Code = "41705214000000", CoateType = CoateType.District,
                    ParentId = 6, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 40, Name = "Лейлекский район", Code = "41705236000000", CoateType = CoateType.District,
                    ParentId = 6, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 41, Name = "Кадамжайский район", Code = "41705258000000", CoateType = CoateType.District,
                    ParentId = 6, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 42, Name = "г. Баткен", Code = "41705410000010", CoateType = CoateType.District, ParentId = 6,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 43, Name = "г. Сулюкта", Code = "41705420000010", CoateType = CoateType.District, ParentId = 6,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 44, Name = "г. Кызыл-Кия", Code = "41705430000010", CoateType = CoateType.District,
                    ParentId = 6, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 45, Name = "Алайский район", Code = "41706207000000", CoateType = CoateType.District,
                    ParentId = 7, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 46, Name = "Араванский район", Code = "41706211000000", CoateType = CoateType.District,
                    ParentId = 7, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 47, Name = "Кара-Сууский район", Code = "41706226000000", CoateType = CoateType.District,
                    ParentId = 7, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 48, Name = "Ноокатский район", Code = "41706242000000", CoateType = CoateType.District,
                    ParentId = 7, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 49, Name = "Кара-Кулжинский район", Code = "41706246000000", CoateType = CoateType.District,
                    ParentId = 7, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 50, Name = "Узгенский район", Code = "41706255000000", CoateType = CoateType.District,
                    ParentId = 7, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 51, Name = "Чон-Алайский  район", Code = "41706259000000", CoateType = CoateType.District,
                    ParentId = 7, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 52, Name = "Кара-Бууринский район", Code = "41707215000000", CoateType = CoateType.District,
                    ParentId = 8, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 53, Name = "Бакай-Атинский район", Code = "41707220000000", CoateType = CoateType.District,
                    ParentId = 8, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 54, Name = "Манасский район", Code = "41707225000000", CoateType = CoateType.District,
                    ParentId = 8, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 55, Name = "Таласский район", Code = "41707232000000", CoateType = CoateType.District,
                    ParentId = 8, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 56, Name = "г. Талас", Code = "41707400000010", CoateType = CoateType.District, ParentId = 8,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 57, Name = "Аламудунский район", Code = "41708203000000", CoateType = CoateType.District,
                    ParentId = 9, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 58, Name = "Ысык-Атинский район", Code = "41708206000000", CoateType = CoateType.District,
                    ParentId = 9, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 59, Name = "Жайылский район", Code = "41708209000000", CoateType = CoateType.District,
                    ParentId = 9, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 61, Name = "Кеминский район", Code = "41708213000000", CoateType = CoateType.District,
                    ParentId = 9, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 62, Name = "Московский район", Code = "41708217000000", CoateType = CoateType.District,
                    ParentId = 9, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 63, Name = "Панфиловский район", Code = "41708219000000", CoateType = CoateType.District,
                    ParentId = 9, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 64, Name = "Сокулукский район", Code = "41708222000000", CoateType = CoateType.District,
                    ParentId = 9, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 65, Name = "Чуйский район", Code = "41708223000000", CoateType = CoateType.District,
                    ParentId = 9, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 66, Name = "г. Токмок", Code = "41708400000010", CoateType = CoateType.District, ParentId = 9,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 67, Name = "Дарыинский айылный аймак", Code = "41705214812000",
                    CoateType = CoateType.Countryside, ParentId = 39, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 68, Name = "Терт-Гюльский айылный аймак", Code = "41705214814000",
                    CoateType = CoateType.Countryside, ParentId = 39, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 69, Name = "Кара-Бакский айылный аймак", Code = "41705214823000",
                    CoateType = CoateType.Countryside, ParentId = 39, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 70, Name = "Кара-Булакский айылный аймак", Code = "41705214824000",
                    CoateType = CoateType.Countryside, ParentId = 39, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 71, Name = "Кыштутский айылный аймак", Code = "41705214835000",
                    CoateType = CoateType.Countryside, ParentId = 39, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 72, Name = "Самаркандекский айылный аймак", Code = "41705214846000",
                    CoateType = CoateType.Countryside, ParentId = 39, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 73, Name = "Ак-Сайский айылный аймак", Code = "41705214848000",
                    CoateType = CoateType.Countryside, ParentId = 39, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 74, Name = "Ак-Татырский айылный аймак", Code = "41705214849000",
                    CoateType = CoateType.Countryside, ParentId = 39, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 75, Name = "Суу-Башынский айылный аймак", Code = "41705214852000",
                    CoateType = CoateType.Countryside, ParentId = 39, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 76, Name = "Ак-Турпакский айылный аймак", Code = "41705258804000",
                    CoateType = CoateType.Countryside, ParentId = 41, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 77, Name = "Алгинский айылный аймак", Code = "41705258808000",
                    CoateType = CoateType.Countryside, ParentId = 41, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 78, Name = "Бирликский айылный аймак", Code = "41705258812000",
                    CoateType = CoateType.Countryside, ParentId = 41, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 79, Name = "Абсамат Масалиевский  айылный аймак", Code = "41705258819000",
                    CoateType = CoateType.Countryside, ParentId = 41, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 80, Name = "Котормоский айылный аймак", Code = "41705258825000",
                    CoateType = CoateType.Countryside, ParentId = 41, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 81, Name = "Майданский айылный аймак", Code = "41705258830000",
                    CoateType = CoateType.Countryside, ParentId = 41, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 82, Name = "Марказский айылный аймак", Code = "41705258834000",
                    CoateType = CoateType.Countryside, ParentId = 41, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 83, Name = "Орозбековский айылный аймак", Code = "41705258842000",
                    CoateType = CoateType.Countryside, ParentId = 41, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 84, Name = "Уч-Коргонский айылный аймак", Code = "41705258849000",
                    CoateType = CoateType.Countryside, ParentId = 41, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 85, Name = "Халмионский айылный аймак", Code = "41705258860000",
                    CoateType = CoateType.Countryside, ParentId = 41, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 86, Name = "Кыргыз-Кыштакский айылный аймак", Code = "41705258861000",
                    CoateType = CoateType.Countryside, ParentId = 41, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 87, Name = "Советский айылный аймак", Code = "41705258864000",
                    CoateType = CoateType.Countryside, ParentId = 41, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 88, Name = "Чаувайский айылный аймак", Code = "41705258867000",
                    CoateType = CoateType.Countryside, ParentId = 41, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 89, Name = "Ак-Сууский айылный аймак", Code = "41705236802000",
                    CoateType = CoateType.Countryside, ParentId = 40, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 90, Name = "Бешкентский айылный аймак", Code = "41705236804000",
                    CoateType = CoateType.Countryside, ParentId = 40, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 91, Name = "Маргунский айылный аймак", Code = "41705236806000",
                    CoateType = CoateType.Countryside, ParentId = 40, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 92, Name = "Джаны-Джерский айылный аймак", Code = "41705236808000",
                    CoateType = CoateType.Countryside, ParentId = 40, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 93, Name = "Лейлекский айылный аймак", Code = "41705236816000",
                    CoateType = CoateType.Countryside, ParentId = 40, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 94, Name = "Катранский айылный аймак", Code = "41705236818000",
                    CoateType = CoateType.Countryside, ParentId = 40, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 95, Name = "Кулундинский айылный аймак", Code = "41705236825000",
                    CoateType = CoateType.Countryside, ParentId = 40, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 96, Name = "Сумбулинский айылный аймак", Code = "41705236836000",
                    CoateType = CoateType.Countryside, ParentId = 40, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 97, Name = "Тогуз-Булакский айылный аймак", Code = "41705236842000",
                    CoateType = CoateType.Countryside, ParentId = 40, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 98, Name = "Ак-Жолский айылный аймак", Code = "41703211804000",
                    CoateType = CoateType.Countryside, ParentId = 23, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 99, Name = "Авлетимский айылный аймак", Code = "41703211808000",
                    CoateType = CoateType.Countryside, ParentId = 23, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 100, Name = "Джаны-Джольский айылный аймак", Code = "41703211813000",
                    CoateType = CoateType.Countryside, ParentId = 23, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 101, Name = "Ак-Сууский айылный аймак", Code = "41703211824000",
                    CoateType = CoateType.Countryside, ParentId = 23, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 102, Name = "Кара-Жыгачский айылный аймак", Code = "41703211832000",
                    CoateType = CoateType.Countryside, ParentId = 23, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 103, Name = "Кашка-Сууский айылный аймак", Code = "41703211836000",
                    CoateType = CoateType.Countryside, ParentId = 23, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 104, Name = "Мавляновский айылный аймак", Code = "41703211842000",
                    CoateType = CoateType.Countryside, ParentId = 23, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 105, Name = "Кызыл-Тууский айылный аймак", Code = "41703211849000",
                    CoateType = CoateType.Countryside, ParentId = 23, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 106, Name = "Кара-Сууский айылный аймак", Code = "41703211857000",
                    CoateType = CoateType.Countryside, ParentId = 23, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 107, Name = "Джерге-Талский айылный аймак", Code = "41703211860000",
                    CoateType = CoateType.Countryside, ParentId = 23, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 108, Name = "Назаралиевский айылный аймак", Code = "41703211863000",
                    CoateType = CoateType.Countryside, ParentId = 23, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 109, Name = "Ак-Коргонский айылный аймак", Code = "41703204804000",
                    CoateType = CoateType.Countryside, ParentId = 21, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 110, Name = "Ак-Тамский айылный аймак", Code = "41703204806000",
                    CoateType = CoateType.Countryside, ParentId = 21, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 111, Name = "Ала-Букинский айылный аймак", Code = "41703204808000",
                    CoateType = CoateType.Countryside, ParentId = 21, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 112, Name = "Кек-Серекский айылный аймак", Code = "41703204827000",
                    CoateType = CoateType.Countryside, ParentId = 21, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 113, Name = "Оруктунский айылный аймак", Code = "41703204847000",
                    CoateType = CoateType.Countryside, ParentId = 21, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 114, Name = "Первомайский айылный аймак", Code = "41703204850000",
                    CoateType = CoateType.Countryside, ParentId = 21, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 115, Name = "Торогелди Балтагуловский айылный аймак", Code = "41703204855000",
                    CoateType = CoateType.Countryside, ParentId = 21, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 116, Name = "Кек-Ташский айылный аймак", Code = "41703204856000",
                    CoateType = CoateType.Countryside, ParentId = 21, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 117, Name = "Акманский айылный аймак", Code = "41703207808000",
                    CoateType = CoateType.Countryside, ParentId = 22, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 118, Name = "Базар-Коргонский айылный аймак", Code = "41703207812000",
                    CoateType = CoateType.Countryside, ParentId = 22, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 119, Name = "Бешик-Жонский айылный аймак", Code = "41703207815000",
                    CoateType = CoateType.Countryside, ParentId = 22, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 120, Name = "Арстанбапский айылный аймак", Code = "41703207826000",
                    CoateType = CoateType.Countryside, ParentId = 22, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 121, Name = "Кызыл-Ункюрский айылный аймак", Code = "41703207832000",
                    CoateType = CoateType.Countryside, ParentId = 22, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 122, Name = "Моголский айылный аймак", Code = "41703207842000",
                    CoateType = CoateType.Countryside, ParentId = 22, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 123, Name = "Сайдыкумский айылный аймак", Code = "41703207856000",
                    CoateType = CoateType.Countryside, ParentId = 22, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 124, Name = "Талдуу-Булакский айылный аймак", Code = "41703207857000",
                    CoateType = CoateType.Countryside, ParentId = 22, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 125, Name = "Кенешский айылный аймак", Code = "41703207859000",
                    CoateType = CoateType.Countryside, ParentId = 22, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 126, Name = "Аралский айылный аймак", Code = "41703215804000",
                    CoateType = CoateType.Countryside, ParentId = 24, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 127, Name = "Бюргендинский айылный аймак", Code = "41703215819000",
                    CoateType = CoateType.Countryside, ParentId = 24, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 128, Name = "Достукский айылный аймак", Code = "41703215821000",
                    CoateType = CoateType.Countryside, ParentId = 24, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 129, Name = "Массынский айылный аймак", Code = "41703215836000",
                    CoateType = CoateType.Countryside, ParentId = 24, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 130, Name = "Момбековский айылный аймак", Code = "41703215840000",
                    CoateType = CoateType.Countryside, ParentId = 24, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 131, Name = "Ноокенский айылный аймак", Code = "41703215846000",
                    CoateType = CoateType.Countryside, ParentId = 24, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 132, Name = "Сакалдинский айылный аймак", Code = "41703215851000",
                    CoateType = CoateType.Countryside, ParentId = 24, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 133, Name = "Шайданский айылный аймак", Code = "41703215876000",
                    CoateType = CoateType.Countryside, ParentId = 24, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 134, Name = "Курманбекский айылный аймак", Code = "41703220805000",
                    CoateType = CoateType.Countryside, ParentId = 25, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 135, Name = "Барпынский айылный аймак", Code = "41703220812000",
                    CoateType = CoateType.Countryside, ParentId = 25, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 136, Name = "Кара-Алминский айылный аймак", Code = "41703220825000",
                    CoateType = CoateType.Countryside, ParentId = 25, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 137, Name = "Кара-Дарыянский айылный аймак", Code = "41703220828000",
                    CoateType = CoateType.Countryside, ParentId = 25, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 138, Name = "Кегартский айылный аймак", Code = "41703220834000",
                    CoateType = CoateType.Countryside, ParentId = 25, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 139, Name = "Кыз-Кельский айылный аймак", Code = "41703220838000",
                    CoateType = CoateType.Countryside, ParentId = 25, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 140, Name = "Кызыл-Тууский айылный аймак", Code = "41703220842000",
                    CoateType = CoateType.Countryside, ParentId = 25, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 141, Name = "Ленинский айылный аймак", Code = "41703220846000",
                    CoateType = CoateType.Countryside, ParentId = 25, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 142, Name = "Багышский айылный аймак", Code = "41703220851000",
                    CoateType = CoateType.Countryside, ParentId = 25, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 143, Name = "Сайпидин-Атабековский айылный аймак", Code = "41703220854000",
                    CoateType = CoateType.Countryside, ParentId = 25, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 144, Name = "Сузакский айылный аймак", Code = "41703220856000",
                    CoateType = CoateType.Countryside, ParentId = 25, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 145, Name = "Таш-Булакский айылный аймак", Code = "41703220863000",
                    CoateType = CoateType.Countryside, ParentId = 25, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 146, Name = "Ырысский айылный аймак", Code = "41703220874000",
                    CoateType = CoateType.Countryside, ParentId = 25, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 147, Name = "Атайский айылный аймак", Code = "41703223805000",
                    CoateType = CoateType.Countryside, ParentId = 26, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 148, Name = "Кок-Иримский айылный аймак", Code = "41703223806000",
                    CoateType = CoateType.Countryside, ParentId = 26, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 149, Name = "Каргалыкский айылный аймак", Code = "41703223812000",
                    CoateType = CoateType.Countryside, ParentId = 26, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 150, Name = "Сары-Булунский айылный аймак", Code = "41703223820000",
                    CoateType = CoateType.Countryside, ParentId = 26, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 151, Name = "Тогуз-Тороуский айылный аймак", Code = "41703223825000",
                    CoateType = CoateType.Countryside, ParentId = 26, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 152, Name = "Бель-Алдынский айылный аймак", Code = "41703225807000",
                    CoateType = CoateType.Countryside, ParentId = 27, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 153, Name = "Джаны-Джольский айылный аймак", Code = "41703225815000",
                    CoateType = CoateType.Countryside, ParentId = 27, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 154, Name = "Кызыл-Озгорушский айылный аймак", Code = "41703225820000",
                    CoateType = CoateType.Countryside, ParentId = 27, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 155, Name = "Ничке-Сайский айылный аймак", Code = "41703225821000",
                    CoateType = CoateType.Countryside, ParentId = 27, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 156, Name = "Кетмень-Дебенский айылный аймак", Code = "41703225825000",
                    CoateType = CoateType.Countryside, ParentId = 27, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 157, Name = "Сары-Камышский айылный аймак", Code = "41703225835000",
                    CoateType = CoateType.Countryside, ParentId = 27, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 158, Name = "Уч-Терекский айылный аймак", Code = "41703225836000",
                    CoateType = CoateType.Countryside, ParentId = 27, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 159, Name = "Аралбаевский айылный аймак", Code = "41703225840000",
                    CoateType = CoateType.Countryside, ParentId = 27, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 160, Name = "Абды Суеркуловский айылный аймак", Code = "41703225843000",
                    CoateType = CoateType.Countryside, ParentId = 27, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 161, Name = "Чолпон-Атинский айылный аймак", Code = "41703225853000",
                    CoateType = CoateType.Countryside, ParentId = 27, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 162, Name = "Каныш-Кыянский айылный аймак", Code = "41703230822000",
                    CoateType = CoateType.Countryside, ParentId = 28, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 163, Name = "Чаткальский айылный аймак", Code = "41703230841000",
                    CoateType = CoateType.Countryside, ParentId = 28, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 164, Name = "Сумсарский айылный аймак", Code = "41703230844000",
                    CoateType = CoateType.Countryside, ParentId = 28, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 165, Name = "Терек-Сайский айылный аймак", Code = "41703230847000",
                    CoateType = CoateType.Countryside, ParentId = 28, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 166, Name = "Ак-Булунский айылный аймак", Code = "41702205805000",
                    CoateType = CoateType.Countryside, ParentId = 14, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 167, Name = "Берю-Башский айылный аймак", Code = "41702205807000",
                    CoateType = CoateType.Countryside, ParentId = 14, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 168, Name = "Кара-Джалский айылный аймак", Code = "41702205812000",
                    CoateType = CoateType.Countryside, ParentId = 14, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 169, Name = "Караколский айылный аймак", Code = "41702205813000",
                    CoateType = CoateType.Countryside, ParentId = 14, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 170, Name = "Кереге-Ташский айылный аймак", Code = "41702205818000",
                    CoateType = CoateType.Countryside, ParentId = 14, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 171, Name = "Нововознесеновский айылный аймак", Code = "41702205825000",
                    CoateType = CoateType.Countryside, ParentId = 14, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 172, Name = "Октябрьский айылный аймак", Code = "41702205832000",
                    CoateType = CoateType.Countryside, ParentId = 14, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 173, Name = "Отрадненский айылный аймак", Code = "41702205835000",
                    CoateType = CoateType.Countryside, ParentId = 14, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 174, Name = "Ак-Чийский айылный аймак", Code = "41702205840000",
                    CoateType = CoateType.Countryside, ParentId = 14, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 175, Name = "Тепкенский айылный аймак", Code = "41702205844000",
                    CoateType = CoateType.Countryside, ParentId = 14, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 176, Name = "Теплоключенский айылный аймак", Code = "41702205848000",
                    CoateType = CoateType.Countryside, ParentId = 14, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 177, Name = "Челпекский айылный аймак", Code = "41702205850000",
                    CoateType = CoateType.Countryside, ParentId = 14, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 178, Name = "Энильчекский айылный аймак", Code = "41702205852000",
                    CoateType = CoateType.Countryside, ParentId = 14, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 179, Name = "Жыргаланский айылный аймак", Code = "41702205855000",
                    CoateType = CoateType.Countryside, ParentId = 14, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 181, Name = "Ак-Дебенский айылный аймак", Code = "41702210805000",
                    CoateType = CoateType.Countryside, ParentId = 15, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 182, Name = "Ак-Шыйракский айылный аймак", Code = "41702210810000",
                    CoateType = CoateType.Countryside, ParentId = 15, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 183, Name = "Барскоонский айылный аймак", Code = "41702210815000",
                    CoateType = CoateType.Countryside, ParentId = 15, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 184, Name = "Дарканский айылный аймак", Code = "41702210820000",
                    CoateType = CoateType.Countryside, ParentId = 15, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 185, Name = "Джаргылчакский айылный аймак", Code = "41702210825000",
                    CoateType = CoateType.Countryside, ParentId = 15, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 186, Name = "Джети-Огузский айылный аймак", Code = "41702210830000",
                    CoateType = CoateType.Countryside, ParentId = 15, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 187, Name = "Ырдыкский айылный аймак", Code = "41702210835000",
                    CoateType = CoateType.Countryside, ParentId = 15, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 188, Name = "Липенский айылный аймак", Code = "41702210840000",
                    CoateType = CoateType.Countryside, ParentId = 15, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 189, Name = "Оргочорский айылный аймак", Code = "41702210845000",
                    CoateType = CoateType.Countryside, ParentId = 15, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 190, Name = "Кызыл-Сууский айылный аймак", Code = "41702210850000",
                    CoateType = CoateType.Countryside, ParentId = 15, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 191, Name = "Алдашевский  айылный аймак", Code = "41702210855000",
                    CoateType = CoateType.Countryside, ParentId = 15, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 192, Name = "Светлополянский айылный аймак", Code = "41702210860000",
                    CoateType = CoateType.Countryside, ParentId = 15, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 193, Name = "Тамгинский айылный аймак", Code = "41702210862000",
                    CoateType = CoateType.Countryside, ParentId = 15, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 194, Name = "Ананьевский айылный аймак", Code = "41702215805000",
                    CoateType = CoateType.Countryside, ParentId = 16, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 195, Name = "Бостеринский айылный аймак", Code = "41702215808000",
                    CoateType = CoateType.Countryside, ParentId = 16, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 196, Name = "Садыр аке айылный аймак", Code = "41702215810000",
                    CoateType = CoateType.Countryside, ParentId = 16, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 197, Name = "Кара-Ойский айылный аймак", Code = "41702215815000",
                    CoateType = CoateType.Countryside, ParentId = 16, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 198, Name = "Кум-Бельский айылный аймак", Code = "41702215820000",
                    CoateType = CoateType.Countryside, ParentId = 16, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 199, Name = "Семеновский айылный аймак", Code = "41702215825000",
                    CoateType = CoateType.Countryside, ParentId = 16, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 200, Name = "Тамчынский айылный аймак", Code = "41702215830000",
                    CoateType = CoateType.Countryside, ParentId = 16, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 201, Name = "Абдрахмановский айылный аймак", Code = "41702215835000",
                    CoateType = CoateType.Countryside, ParentId = 16, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 202, Name = "Темировский айылный аймак", Code = "41702215840000",
                    CoateType = CoateType.Countryside, ParentId = 16, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 203, Name = "Тору-Айгырский айылный аймак", Code = "41702215845000",
                    CoateType = CoateType.Countryside, ParentId = 16, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 204, Name = "Орюктинский айылный аймак", Code = "41702215850000",
                    CoateType = CoateType.Countryside, ParentId = 16, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 205, Name = "Чон-Сары-Ойский айылный аймак", Code = "41702215855000",
                    CoateType = CoateType.Countryside, ParentId = 16, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 206, Name = "Ак-Терекский айылный аймак", Code = "41702220805000",
                    CoateType = CoateType.Countryside, ParentId = 17, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 207, Name = "Кель-Терский айылный аймак", Code = "41702220806000",
                    CoateType = CoateType.Countryside, ParentId = 17, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 208, Name = "Кек-Мойнокский айылный аймак", Code = "41702220807000",
                    CoateType = CoateType.Countryside, ParentId = 17, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 209, Name = "Болот Мамбетовский  айылный аймак", Code = "41702220808000",
                    CoateType = CoateType.Countryside, ParentId = 17, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 210, Name = "Кюн-Чыгышский айылный аймак", Code = "41702220810000",
                    CoateType = CoateType.Countryside, ParentId = 17, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 211, Name = "Тонский айылный аймак", Code = "41702220815000",
                    CoateType = CoateType.Countryside, ParentId = 17, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 212, Name = "Терт-Кульский айылный аймак", Code = "41702220820000",
                    CoateType = CoateType.Countryside, ParentId = 17, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 213, Name = "Улаколский айылный аймак", Code = "41702220825000",
                    CoateType = CoateType.Countryside, ParentId = 17, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 214, Name = "Каджи-Сайский айылный аймак", Code = "41702220828000",
                    CoateType = CoateType.Countryside, ParentId = 17, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 215, Name = "Аралский айылный аймак", Code = "41702225810000",
                    CoateType = CoateType.Countryside, ParentId = 18, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 216, Name = "Иссык-Кельский айылный аймак", Code = "41702225815000",
                    CoateType = CoateType.Countryside, ParentId = 18, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 217, Name = "Кутургинский айылный аймак", Code = "41702225835000",
                    CoateType = CoateType.Countryside, ParentId = 18, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 218, Name = "Михайловский айылный аймак", Code = "41702225841000",
                    CoateType = CoateType.Countryside, ParentId = 18, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 219, Name = "Тогуз-Булакский айылный аймак", Code = "41702225847000",
                    CoateType = CoateType.Countryside, ParentId = 18, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 220, Name = "Сан-Ташский айылный аймак", Code = "41702225865000",
                    CoateType = CoateType.Countryside, ParentId = 18, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 221, Name = "Сары-Булакский айылный аймак", Code = "41702225870000",
                    CoateType = CoateType.Countryside, ParentId = 18, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 222, Name = "Ак-Булунский айылный аймак", Code = "41702225873000",
                    CoateType = CoateType.Countryside, ParentId = 18, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 223, Name = "Талды-Сууский айылный аймак", Code = "41702225876000",
                    CoateType = CoateType.Countryside, ParentId = 18, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 224, Name = "Карасаевский айылный аймак", Code = "41702225883000",
                    CoateType = CoateType.Countryside, ParentId = 18, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 225, Name = "Тюпский айылный аймак", Code = "41702225889000",
                    CoateType = CoateType.Countryside, ParentId = 18, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 226, Name = "Чон-Ташский айылный аймак", Code = "41702225893000",
                    CoateType = CoateType.Countryside, ParentId = 18, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 227, Name = "Ак-Булакский айылный аймак", Code = "41702225896000",
                    CoateType = CoateType.Countryside, ParentId = 18, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 228, Name = "Ак-Талский айылный аймак", Code = "41704210806000",
                    CoateType = CoateType.Countryside, ParentId = 33, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 229, Name = "Ак-Чийский айылный аймак", Code = "41704210808000",
                    CoateType = CoateType.Countryside, ParentId = 33, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 230, Name = "Баетовский айылный аймак", Code = "41704210809000",
                    CoateType = CoateType.Countryside, ParentId = 33, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 231, Name = "Терекский айылный аймак", Code = "41704210811000",
                    CoateType = CoateType.Countryside, ParentId = 33, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 232, Name = "Кара-Бюргенский айылный аймак", Code = "41704210816000",
                    CoateType = CoateType.Countryside, ParentId = 33, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 233, Name = "Конорчокский айылный аймак", Code = "41704210818000",
                    CoateType = CoateType.Countryside, ParentId = 33, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 234, Name = "Жерге-Тальский айылный аймак", Code = "41704210819000",
                    CoateType = CoateType.Countryside, ParentId = 33, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 235, Name = "Кош-Дебенский айылный аймак", Code = "41704210820000",
                    CoateType = CoateType.Countryside, ParentId = 33, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 236, Name = "Кызыл-Белесский айылный аймак", Code = "41704210822000",
                    CoateType = CoateType.Countryside, ParentId = 33, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 237, Name = "Джаны-Талапский айылный аймак", Code = "41704210825000",
                    CoateType = CoateType.Countryside, ParentId = 33, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 238, Name = "Тоголок-Молдоский айылный аймак", Code = "41704210828000",
                    CoateType = CoateType.Countryside, ParentId = 33, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 239, Name = "Кек - Джарский айылный аймак", Code = "41704210830000",
                    CoateType = CoateType.Countryside, ParentId = 33, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 240, Name = "Угутский айылный аймак", Code = "41704210840000",
                    CoateType = CoateType.Countryside, ParentId = 33, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 241, Name = "Ак-Джарский айылный аймак", Code = "41704220803000",
                    CoateType = CoateType.Countryside, ParentId = 34, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 242, Name = "Ак-Моюнский айылный аймак", Code = "41704220806000",
                    CoateType = CoateType.Countryside, ParentId = 34, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 243, Name = "Ак-Музский айылный аймак", Code = "41704220807000",
                    CoateType = CoateType.Countryside, ParentId = 34, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 244, Name = "Ак-Талинский айылный аймак", Code = "41704220808000",
                    CoateType = CoateType.Countryside, ParentId = 34, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 245, Name = "Ат-Башынский айылный аймак", Code = "41704220812000",
                    CoateType = CoateType.Countryside, ParentId = 34, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 246, Name = "Ача-Каиндинский айылный аймак", Code = "41704220813000",
                    CoateType = CoateType.Countryside, ParentId = 34, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 247, Name = "Баш-Каиндинский айылный аймак", Code = "41704220817000",
                    CoateType = CoateType.Countryside, ParentId = 34, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 248, Name = "Казыбекский айылный аймак", Code = "41704220830000",
                    CoateType = CoateType.Countryside, ParentId = 34, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 249, Name = "Кара-Коюнский айылный аймак", Code = "41704220832000",
                    CoateType = CoateType.Countryside, ParentId = 34, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 250, Name = "Кара-Сууский айылный аймак", Code = "41704220836000",
                    CoateType = CoateType.Countryside, ParentId = 34, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 251, Name = "Талды-Сууский айылный аймак", Code = "41704220845000",
                    CoateType = CoateType.Countryside, ParentId = 34, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 252, Name = "Баш-Куугандынский айылный аймак", Code = "41704230804000",
                    CoateType = CoateType.Countryside, ParentId = 35, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 253, Name = "Джаны-Арыкский айылный аймак", Code = "41704230806000",
                    CoateType = CoateType.Countryside, ParentId = 35, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 254, Name = "Джумгальский айылный аймак", Code = "41704230809000",
                    CoateType = CoateType.Countryside, ParentId = 35, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 255, Name = "Кабакский айылный аймак", Code = "41704230813000",
                    CoateType = CoateType.Countryside, ParentId = 35, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 256, Name = "Кек-Ойский айылный аймак", Code = "41704230815000",
                    CoateType = CoateType.Countryside, ParentId = 35, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 257, Name = "Байзаковский айылный аймак", Code = "41704230817000",
                    CoateType = CoateType.Countryside, ParentId = 35, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 258, Name = "Куйручукский айылный аймак", Code = "41704230825000",
                    CoateType = CoateType.Countryside, ParentId = 35, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 259, Name = "Чон-Добонский айылный аймак", Code = "41704230826000",
                    CoateType = CoateType.Countryside, ParentId = 35, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 260, Name = "Тугол-Сайский айылный аймак", Code = "41704230834000",
                    CoateType = CoateType.Countryside, ParentId = 35, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 261, Name = "Суюмбаевский айылный аймак", Code = "41704230835000",
                    CoateType = CoateType.Countryside, ParentId = 35, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 262, Name = "Чаекский айылный аймак", Code = "41704230836000",
                    CoateType = CoateType.Countryside, ParentId = 35, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 263, Name = "Кызыл-Жылдызский айылный аймак", Code = "41704230837000",
                    CoateType = CoateType.Countryside, ParentId = 35, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 264, Name = "Мин-Кушский айылный аймак", Code = "41704230840000",
                    CoateType = CoateType.Countryside, ParentId = 35, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 265, Name = "Ак-Кыянский айылный аймак", Code = "41704235806000",
                    CoateType = CoateType.Countryside, ParentId = 36, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 266, Name = "Кара-Сууский айылный аймак", Code = "41704235812000",
                    CoateType = CoateType.Countryside, ParentId = 36, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 267, Name = "Кочкорский айылный аймак", Code = "41704235816000",
                    CoateType = CoateType.Countryside, ParentId = 36, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 268, Name = "Кош-Дебенский айылный аймак", Code = "41704235819000",
                    CoateType = CoateType.Countryside, ParentId = 36, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 269, Name = "Кум-Дебенский айылный аймак", Code = "41704235825000",
                    CoateType = CoateType.Countryside, ParentId = 36, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 270, Name = "Сары-Булакский айылный аймак", Code = "41704235830000",
                    CoateType = CoateType.Countryside, ParentId = 36, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 271, Name = "Семиз-Бельский айылный аймак", Code = "41704235832000",
                    CoateType = CoateType.Countryside, ParentId = 36, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 272, Name = "Талаа-Булакский айылный аймак", Code = "41704235835000",
                    CoateType = CoateType.Countryside, ParentId = 36, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 273, Name = "Кок-Жарский айылный аймак", Code = "41704235837000",
                    CoateType = CoateType.Countryside, ParentId = 36, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 274, Name = "Чолпонский айылный аймак", Code = "41704235842000",
                    CoateType = CoateType.Countryside, ParentId = 36, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 275, Name = "Сон-Кульский айылный аймак", Code = "41704235843000",
                    CoateType = CoateType.Countryside, ParentId = 36, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 276, Name = "Ак-Кудукский айылный аймак", Code = "41704245806000",
                    CoateType = CoateType.Countryside, ParentId = 37, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 277, Name = "Дебелинский айылный аймак", Code = "41704245812000",
                    CoateType = CoateType.Countryside, ParentId = 37, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 278, Name = "Джан-Булакский айылный аймак", Code = "41704245815000",
                    CoateType = CoateType.Countryside, ParentId = 37, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 279, Name = "Джергеталский айылный аймак", Code = "41704245818000",
                    CoateType = CoateType.Countryside, ParentId = 37, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 280, Name = "Казан-Куйганский айылный аймак", Code = "41704245825000",
                    CoateType = CoateType.Countryside, ParentId = 37, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 281, Name = "Кара-Куджурский айылный аймак", Code = "41704245829000",
                    CoateType = CoateType.Countryside, ParentId = 37, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 282, Name = "Эмгекчильский айылный аймак", Code = "41704245832000",
                    CoateType = CoateType.Countryside, ParentId = 37, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 283, Name = "Мин-Булакский айылный аймак", Code = "41704245835000",
                    CoateType = CoateType.Countryside, ParentId = 37, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 284, Name = "Он-Арчинский айылный аймак", Code = "41704245840000",
                    CoateType = CoateType.Countryside, ParentId = 37, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 285, Name = "Ортокский айылный аймак", Code = "41704245844000",
                    CoateType = CoateType.Countryside, ParentId = 37, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 286, Name = "Учкунский айылный аймак", Code = "41704245845000",
                    CoateType = CoateType.Countryside, ParentId = 37, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 287, Name = "Чет-Нуринский айылный аймак", Code = "41704245850000",
                    CoateType = CoateType.Countryside, ParentId = 37, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 288, Name = "Эмгек-Талинский айылный аймак", Code = "41704245855000",
                    CoateType = CoateType.Countryside, ParentId = 37, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 289, Name = "Сары-Ойский айылный аймак", Code = "41704245860000",
                    CoateType = CoateType.Countryside, ParentId = 37, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 290, Name = "Достукский айылный аймак", Code = "41704245863000",
                    CoateType = CoateType.Countryside, ParentId = 37, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 291, Name = "Алайский айылный аймак имени К.Белекбаева", Code = "41706207804000",
                    CoateType = CoateType.Countryside, ParentId = 45, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 292, Name = "Будалыкский айылный аймак", Code = "41706207809000",
                    CoateType = CoateType.Countryside, ParentId = 45, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 293, Name = "Бюлелинский айылный аймак", Code = "41706207811000",
                    CoateType = CoateType.Countryside, ParentId = 45, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 294, Name = "Гульчинский айылный аймак", Code = "41706207814000",
                    CoateType = CoateType.Countryside, ParentId = 45, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 295, Name = "Джошолунский айылный аймак", Code = "41706207818000",
                    CoateType = CoateType.Countryside, ParentId = 45, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 296, Name = "Конур-Добонский айылный аймак", Code = "41706207822000",
                    CoateType = CoateType.Countryside, ParentId = 45, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 297, Name = "Кабылан-Колский айылный аймак", Code = "41706207823000",
                    CoateType = CoateType.Countryside, ParentId = 45, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 298, Name = "Корульский айылный аймак", Code = "41706207825000",
                    CoateType = CoateType.Countryside, ParentId = 45, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 299, Name = "Ленинский айылный аймак", Code = "41706207830000",
                    CoateType = CoateType.Countryside, ParentId = 45, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 300, Name = "Талды-Сууский айылный аймак", Code = "41706207838000",
                    CoateType = CoateType.Countryside, ParentId = 45, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 301, Name = "Сары-Моголский айылный аймак", Code = "41706207839000",
                    CoateType = CoateType.Countryside, ParentId = 45, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 302, Name = "Уч-Дебенский айылный аймак", Code = "41706207840000",
                    CoateType = CoateType.Countryside, ParentId = 45, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 303, Name = "Жаны-Алайский айылный аймак", Code = "41706207841000",
                    CoateType = CoateType.Countryside, ParentId = 45, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 304, Name = "Сары-Ташский айылный аймак", Code = "41706207844000",
                    CoateType = CoateType.Countryside, ParentId = 45, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 305, Name = "Алля Анаровский айылный аймак", Code = "41706211807000",
                    CoateType = CoateType.Countryside, ParentId = 46, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 306, Name = "С.Юсуповский айылный аймак", Code = "41706211809000",
                    CoateType = CoateType.Countryside, ParentId = 46, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 307, Name = "Мангытский айылный аймак", Code = "41706211812000",
                    CoateType = CoateType.Countryside, ParentId = 46, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 308, Name = "Керме-Тооский айылный аймак", Code = "41706211815000",
                    CoateType = CoateType.Countryside, ParentId = 46, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 309, Name = "Тепе-Коргонский айылный аймак", Code = "41706211823000",
                    CoateType = CoateType.Countryside, ParentId = 46, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 310, Name = "Нурабадский айылный аймак", Code = "41706211824000",
                    CoateType = CoateType.Countryside, ParentId = 46, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 311, Name = "Тео-Моюнский айылный аймак", Code = "41706211829000",
                    CoateType = CoateType.Countryside, ParentId = 46, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 312, Name = "Чек-Абадский айылный аймак", Code = "41706211835000",
                    CoateType = CoateType.Countryside, ParentId = 46, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 313, Name = "Алайкууский айылный аймак", Code = "41706246804000",
                    CoateType = CoateType.Countryside, ParentId = 49, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 314, Name = "Капчыгайский айылный аймак", Code = "41706246812000",
                    CoateType = CoateType.Countryside, ParentId = 49, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 315, Name = "Кенешский айылный аймак", Code = "41706246815000",
                    CoateType = CoateType.Countryside, ParentId = 49, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 316, Name = "Карагузский айылный аймак", Code = "41706246816000",
                    CoateType = CoateType.Countryside, ParentId = 49, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 317, Name = "Кара-Кочкорский айылный аймак", Code = "41706246818000",
                    CoateType = CoateType.Countryside, ParentId = 49, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 318, Name = "Кара-Кульджинский айылный аймак", Code = "41706246820000",
                    CoateType = CoateType.Countryside, ParentId = 49, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 319, Name = "Кызыл-Жарский айылный аймак", Code = "41706246826000",
                    CoateType = CoateType.Countryside, ParentId = 49, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 320, Name = "Ылай-Талинский айылный аймак", Code = "41706246834000",
                    CoateType = CoateType.Countryside, ParentId = 49, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 321, Name = "Ой-Талский айылный аймак", Code = "41706246838000",
                    CoateType = CoateType.Countryside, ParentId = 49, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 322, Name = "Сары-Булакский айылный аймак", Code = "41706246849000",
                    CoateType = CoateType.Countryside, ParentId = 49, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 323, Name = "Чалминский айылный аймак", Code = "41706246860000",
                    CoateType = CoateType.Countryside, ParentId = 49, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 324, Name = "Кашка-Жолский айылный аймак", Code = "41706246861000",
                    CoateType = CoateType.Countryside, ParentId = 49, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 325, Name = "Ак-Ташский айылный аймак", Code = "41706226804000",
                    CoateType = CoateType.Countryside, ParentId = 47, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 326, Name = "Джаны-Арыкский айылный аймак", Code = "41706226806000",
                    CoateType = CoateType.Countryside, ParentId = 47, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 327, Name = "Жоошский айылный аймак", Code = "41706226807000",
                    CoateType = CoateType.Countryside, ParentId = 47, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 328, Name = "Катта-Талдыкский айылный аймак", Code = "41706226812000",
                    CoateType = CoateType.Countryside, ParentId = 47, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 329, Name = "Кашгар-Кыштакский айылный аймак", Code = "41706226816000",
                    CoateType = CoateType.Countryside, ParentId = 47, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 330, Name = "Кызыл-Кыштакский айылный аймак", Code = "41706226819000",
                    CoateType = CoateType.Countryside, ParentId = 47, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 331, Name = "Кызыл-Сууский айылный аймак", Code = "41706226822000",
                    CoateType = CoateType.Countryside, ParentId = 47, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 332, Name = "Мадынский айылный аймак", Code = "41706226826000",
                    CoateType = CoateType.Countryside, ParentId = 47, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 333, Name = "Наримановский айылный аймак", Code = "41706226830000",
                    CoateType = CoateType.Countryside, ParentId = 47, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 334, Name = "Отуз-Адырский айылный аймак", Code = "41706226838000",
                    CoateType = CoateType.Countryside, ParentId = 47, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 335, Name = "Сары-Колотский айылный аймак", Code = "41706226840000",
                    CoateType = CoateType.Countryside, ParentId = 47, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 336, Name = "Папанский айылный аймак", Code = "41706226842000",
                    CoateType = CoateType.Countryside, ParentId = 47, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 337, Name = "Савайский айылный аймак", Code = "41706226850000",
                    CoateType = CoateType.Countryside, ParentId = 47, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 338, Name = "Сарайский айылный аймак", Code = "41706226854000",
                    CoateType = CoateType.Countryside, ParentId = 47, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 339, Name = "Телейкенский айылный аймак", Code = "41706226862000",
                    CoateType = CoateType.Countryside, ParentId = 47, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 340, Name = "Шаркский айылный аймак", Code = "41706226868000",
                    CoateType = CoateType.Countryside, ParentId = 47, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 341, Name = "Бельский айылный аймак", Code = "41706242808000",
                    CoateType = CoateType.Countryside, ParentId = 48, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 342, Name = "Гюльстанский айылный аймак", Code = "41706242811000",
                    CoateType = CoateType.Countryside, ParentId = 48, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 343, Name = "Кара-Ташский айылный аймак", Code = "41706242812000",
                    CoateType = CoateType.Countryside, ParentId = 48, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 344, Name = "Кулатовский айылный аймак", Code = "41706242813000",
                    CoateType = CoateType.Countryside, ParentId = 48, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 345, Name = "Джаны-Ноокатский айылный аймак", Code = "41706242814000",
                    CoateType = CoateType.Countryside, ParentId = 48, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 346, Name = "Кенешский айылный аймак", Code = "41706242825000",
                    CoateType = CoateType.Countryside, ParentId = 48, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 347, Name = "Кыргыз-Атинский айылный аймак", Code = "41706242829000",
                    CoateType = CoateType.Countryside, ParentId = 48, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 348, Name = "Айылный аймак  им. Токтомата Зулпуева", Code = "41706242832000",
                    CoateType = CoateType.Countryside, ParentId = 48, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 349, Name = "Исановский айылный аймак", Code = "41706242836000",
                    CoateType = CoateType.Countryside, ParentId = 48, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 350, Name = "Кок-Бельский айылный аймак", Code = "41706242838000",
                    CoateType = CoateType.Countryside, ParentId = 48, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 351, Name = "Кызыл-Октябрьский айылный аймак", Code = "41706242839000",
                    CoateType = CoateType.Countryside, ParentId = 48, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 352, Name = "Он Эки-Бельский айылный аймак", Code = "41706242845000",
                    CoateType = CoateType.Countryside, ParentId = 48, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 353, Name = "Теелес айылный аймак", Code = "41706242850000", CoateType = CoateType.Countryside,
                    ParentId = 48, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 354, Name = "Мирмахмудовский айылный аймак", Code = "41706242856000",
                    CoateType = CoateType.Countryside, ParentId = 48, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 355, Name = "Ынтымакский айылный аймак", Code = "41706242862000",
                    CoateType = CoateType.Countryside, ParentId = 48, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 356, Name = "Найманский айылный аймак", Code = "41706242865000",
                    CoateType = CoateType.Countryside, ParentId = 48, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 357, Name = "Ак-Джарский айылный аймак", Code = "41706255804000",
                    CoateType = CoateType.Countryside, ParentId = 50, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 358, Name = "Баш-Дебенский айылный аймак", Code = "41706255808000",
                    CoateType = CoateType.Countryside, ParentId = 50, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 359, Name = "Джалпак-Ташский айылный аймак", Code = "41706255813000",
                    CoateType = CoateType.Countryside, ParentId = 50, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 360, Name = "Джыландынский айылный аймак", Code = "41706255815000",
                    CoateType = CoateType.Countryside, ParentId = 50, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 361, Name = "Ден-Булакский айылный аймак", Code = "41706255817000",
                    CoateType = CoateType.Countryside, ParentId = 50, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 362, Name = "Заргерский айылный аймак", Code = "41706255822000",
                    CoateType = CoateType.Countryside, ParentId = 50, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 363, Name = "Жазыский айылный аймак", Code = "41706255824000",
                    CoateType = CoateType.Countryside, ParentId = 50, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 364, Name = "Ийри-Сууский айылный аймак", Code = "41706255826000",
                    CoateType = CoateType.Countryside, ParentId = 50, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 365, Name = "Чангетский айылный аймак", Code = "41706255828000",
                    CoateType = CoateType.Countryside, ParentId = 50, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 366, Name = "Кара-Ташский айылный аймак", Code = "41706255830000",
                    CoateType = CoateType.Countryside, ParentId = 50, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 367, Name = "Кароолский айылный аймак", Code = "41706255832000",
                    CoateType = CoateType.Countryside, ParentId = 50, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 368, Name = "Кельдюкский айылный аймак", Code = "41706255840000",
                    CoateType = CoateType.Countryside, ParentId = 50, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 369, Name = "Кызыл-Октябрьский айылный аймак", Code = "41706255844000",
                    CoateType = CoateType.Countryside, ParentId = 50, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 370, Name = "Кызыл-Тооский айылный аймак", Code = "41706255847000",
                    CoateType = CoateType.Countryside, ParentId = 50, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 371, Name = "Куршабский айылный аймак", Code = "41706255853000",
                    CoateType = CoateType.Countryside, ParentId = 50, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 372, Name = "Мырза-Акинский айылный аймак", Code = "41706255859000",
                    CoateType = CoateType.Countryside, ParentId = 50, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 373, Name = "Алтын-Булакский айылный аймак", Code = "41706255860000",
                    CoateType = CoateType.Countryside, ParentId = 50, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 374, Name = "Саламаликский айылный аймак", Code = "41706255865000",
                    CoateType = CoateType.Countryside, ParentId = 50, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 375, Name = "Терт-Кельский айылный аймак", Code = "41706255876000",
                    CoateType = CoateType.Countryside, ParentId = 50, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 376, Name = "Жекендинский айылный аймак", Code = "41706259816000",
                    CoateType = CoateType.Countryside, ParentId = 51, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 377, Name = "Кашка-Сууский айылный аймак", Code = "41706259824000",
                    CoateType = CoateType.Countryside, ParentId = 51, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 378, Name = "Чон-Алайский айылный аймак", Code = "41706259851000",
                    CoateType = CoateType.Countryside, ParentId = 51, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 379, Name = "Шадыканский айылный аймак", Code = "41707220808000",
                    CoateType = CoateType.Countryside, ParentId = 53, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 380, Name = "Боо-Терекский  айылный аймак", Code = "41707220823000",
                    CoateType = CoateType.Countryside, ParentId = 53, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 381, Name = "Акназаровский айылный аймак", Code = "41707220826000",
                    CoateType = CoateType.Countryside, ParentId = 53, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 382, Name = "Кен-Аралский айылный аймак", Code = "41707220828000",
                    CoateType = CoateType.Countryside, ParentId = 53, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 383, Name = "Ленинпольский айылный аймак", Code = "41707220830000",
                    CoateType = CoateType.Countryside, ParentId = 53, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 384, Name = "Мин-Булакский айылный аймак", Code = "41707220833000",
                    CoateType = CoateType.Countryside, ParentId = 53, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 385, Name = "Озгерюшский айылный аймак", Code = "41707220835000",
                    CoateType = CoateType.Countryside, ParentId = 53, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 386, Name = "Ак-Дебенский айылный аймак", Code = "41707220840000",
                    CoateType = CoateType.Countryside, ParentId = 53, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 387, Name = "Ороский айылный аймак", Code = "41707220843000",
                    CoateType = CoateType.Countryside, ParentId = 53, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 388, Name = "Ак-Чийский айылный аймак", Code = "41707215804000",
                    CoateType = CoateType.Countryside, ParentId = 52, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 389, Name = "Бейшекенский айылный аймак", Code = "41707215805000",
                    CoateType = CoateType.Countryside, ParentId = 52, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 390, Name = "Бакыянский айылный аймак", Code = "41707215806000",
                    CoateType = CoateType.Countryside, ParentId = 52, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 391, Name = "Аманбаевский айылный аймак", Code = "41707215807000",
                    CoateType = CoateType.Countryside, ParentId = 52, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 392, Name = "Бакайырский айылный аймак", Code = "41707215815000",
                    CoateType = CoateType.Countryside, ParentId = 52, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 393, Name = "Кара-Бууринский айылный аймак", Code = "41707215818000",
                    CoateType = CoateType.Countryside, ParentId = 52, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 394, Name = "Кек-Сайский айылный аймак", Code = "41707215821000",
                    CoateType = CoateType.Countryside, ParentId = 52, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 395, Name = "Чолпонбайский айылный аймак", Code = "41707215840000",
                    CoateType = CoateType.Countryside, ParentId = 52, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 396, Name = "Шекерский айылный аймак", Code = "41707215843000",
                    CoateType = CoateType.Countryside, ParentId = 52, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 397, Name = "Маймакский айылный аймак", Code = "41707215846000",
                    CoateType = CoateType.Countryside, ParentId = 52, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 398, Name = "Каиндинский айылный аймак", Code = "41707225818000",
                    CoateType = CoateType.Countryside, ParentId = 54, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 399, Name = "Киргизия  айылный аймак", Code = "41707225820000",
                    CoateType = CoateType.Countryside, ParentId = 54, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 400, Name = "Майский айылный аймак", Code = "41707225826000",
                    CoateType = CoateType.Countryside, ParentId = 54, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 401, Name = "Покровский айылный аймак", Code = "41707225833000",
                    CoateType = CoateType.Countryside, ParentId = 54, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 402, Name = "Уч-Коргонский айылный аймак", Code = "41707225845000",
                    CoateType = CoateType.Countryside, ParentId = 54, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 403, Name = "Аралский айылный аймак", Code = "41707232804000",
                    CoateType = CoateType.Countryside, ParentId = 55, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 404, Name = "Джергеталский айылный аймак", Code = "41707232810000",
                    CoateType = CoateType.Countryside, ParentId = 55, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 405, Name = "Долонский айылный аймак", Code = "41707232813000",
                    CoateType = CoateType.Countryside, ParentId = 55, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 406, Name = "Кок-Ойский  айылный аймак", Code = "41707232820000",
                    CoateType = CoateType.Countryside, ParentId = 55, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 407, Name = "Бекмолдоевский айылный аймак", Code = "41707232825000",
                    CoateType = CoateType.Countryside, ParentId = 55, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 408, Name = "Айдаралиевский айылный аймак", Code = "41707232829000",
                    CoateType = CoateType.Countryside, ParentId = 55, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 409, Name = "Нуржановский айылный аймак", Code = "41707232832000",
                    CoateType = CoateType.Countryside, ParentId = 55, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 410, Name = "Айылный аймак Бердике Баатыра", Code = "41707232843000",
                    CoateType = CoateType.Countryside, ParentId = 55, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 411, Name = "Осмонкуловский  айылный аймак", Code = "41707232847000",
                    CoateType = CoateType.Countryside, ParentId = 55, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 412, Name = "Омуралиевский  айылный аймак", Code = "41707232859000",
                    CoateType = CoateType.Countryside, ParentId = 55, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 413, Name = "Куугандинский айылный аймак", Code = "41707232860000",
                    CoateType = CoateType.Countryside, ParentId = 55, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 414, Name = "Кара-Суйский айылный аймак", Code = "41707232861000",
                    CoateType = CoateType.Countryside, ParentId = 55, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 415, Name = "Калбинский айылный аймак", Code = "41707232862000",
                    CoateType = CoateType.Countryside, ParentId = 55, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 416, Name = "Ак-Дебенский айылный аймак", Code = "41708203803000",
                    CoateType = CoateType.Countryside, ParentId = 57, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 417, Name = "Ала-Арчинский айылный аймак", Code = "41708203805000",
                    CoateType = CoateType.Countryside, ParentId = 57, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 418, Name = "Аламудунский айылный аймак", Code = "41708203807000",
                    CoateType = CoateType.Countryside, ParentId = 57, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 419, Name = "Арашанский айылный аймак", Code = "41708203809000",
                    CoateType = CoateType.Countryside, ParentId = 57, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 420, Name = "Васильевский айылный аймак", Code = "41708203814000",
                    CoateType = CoateType.Countryside, ParentId = 57, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 421, Name = "Грозденский айылный аймак", Code = "41708203819000",
                    CoateType = CoateType.Countryside, ParentId = 57, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 422, Name = "Кара-Джыгачский айылный аймак", Code = "41708203826000",
                    CoateType = CoateType.Countryside, ParentId = 57, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 423, Name = "Кок-Джарский айылный аймак", Code = "41708203828000",
                    CoateType = CoateType.Countryside, ParentId = 57, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 424, Name = "Лебединовский айылный аймак", Code = "41708203831000",
                    CoateType = CoateType.Countryside, ParentId = 57, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 425, Name = "Ленинский айылный аймак", Code = "41708203834000",
                    CoateType = CoateType.Countryside, ParentId = 57, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 426, Name = "Маевский айылный аймак", Code = "41708203838000",
                    CoateType = CoateType.Countryside, ParentId = 57, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 427, Name = "Нижнеаларчинский айылный аймак", Code = "41708203845000",
                    CoateType = CoateType.Countryside, ParentId = 57, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 428, Name = "Октябрьский айылный аймак", Code = "41708203852000",
                    CoateType = CoateType.Countryside, ParentId = 57, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 429, Name = "Байтик айылный аймак", Code = "41708203855000", CoateType = CoateType.Countryside,
                    ParentId = 57, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 430, Name = "Пригородный айылный аймак", Code = "41708203859000",
                    CoateType = CoateType.Countryside, ParentId = 57, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 431, Name = "Таш-Дебенский айылный аймак", Code = "41708203864000",
                    CoateType = CoateType.Countryside, ParentId = 57, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 432, Name = "Таш-Мойнокский айылный аймак", Code = "41708203866000",
                    CoateType = CoateType.Countryside, ParentId = 57, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 433, Name = "Жайылский айылный аймак", Code = "41708209811000",
                    CoateType = CoateType.Countryside, ParentId = 59, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 434, Name = "Кара-Сууский айылный аймак", Code = "41708209812000",
                    CoateType = CoateType.Countryside, ParentId = 59, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 435, Name = "Красновосточный айылный аймак", Code = "41708209814000",
                    CoateType = CoateType.Countryside, ParentId = 59, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 436, Name = "Кызыл-Дыйканский айылный аймак", Code = "41708209817000",
                    CoateType = CoateType.Countryside, ParentId = 59, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 437, Name = "Ак-Башатский айылный аймак", Code = "41708209822000",
                    CoateType = CoateType.Countryside, ParentId = 59, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 438, Name = "Полтавский айылный аймак", Code = "41708209829000",
                    CoateType = CoateType.Countryside, ParentId = 59, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 439, Name = "Суусамырский айылный аймак", Code = "41708209830000",
                    CoateType = CoateType.Countryside, ParentId = 59, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 440, Name = "Сары-Кооский айылный аймак", Code = "41708209838000",
                    CoateType = CoateType.Countryside, ParentId = 59, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 441, Name = "Сары-Булакский айылный аймак", Code = "41708209840000",
                    CoateType = CoateType.Countryside, ParentId = 59, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 442, Name = "Сосновский айылный аймак", Code = "41708209844000",
                    CoateType = CoateType.Countryside, ParentId = 59, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 443, Name = "Степнинский айылный аймак", Code = "41708209848000",
                    CoateType = CoateType.Countryside, ParentId = 59, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 444, Name = "Талды-Булакский айылный аймак", Code = "41708209857000",
                    CoateType = CoateType.Countryside, ParentId = 59, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 445, Name = "Алмалунский айылный аймак", Code = "41708213804000",
                    CoateType = CoateType.Countryside, ParentId = 61, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 446, Name = "Боролдойский айылный аймак", Code = "41708213808000",
                    CoateType = CoateType.Countryside, ParentId = 61, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 447, Name = "Жаны-Алышский айылный аймак", Code = "41708213813000",
                    CoateType = CoateType.Countryside, ParentId = 61, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 448, Name = "Ильичевский айылный аймак", Code = "41708213817000",
                    CoateType = CoateType.Countryside, ParentId = 61, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 449, Name = "Кара-Булакский айылный аймак", Code = "41708213820000",
                    CoateType = CoateType.Countryside, ParentId = 61, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 450, Name = "Кок-Ойрокский айылный аймак", Code = "41708213823000",
                    CoateType = CoateType.Countryside, ParentId = 61, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 451, Name = "А.Дуйшеевский айылный аймак", Code = "41708213826000",
                    CoateType = CoateType.Countryside, ParentId = 61, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 452, Name = "Кызыл-Октябрьский айылный аймак", Code = "41708213830000",
                    CoateType = CoateType.Countryside, ParentId = 61, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 453, Name = "Чым-Коргонский айылный аймак", Code = "41708213839000",
                    CoateType = CoateType.Countryside, ParentId = 61, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 454, Name = "Чон-Кеминский айылный аймак", Code = "41708213842000",
                    CoateType = CoateType.Countryside, ParentId = 61, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 455, Name = "Ак-Тюзский айылный аймак", Code = "41708213845000",
                    CoateType = CoateType.Countryside, ParentId = 61, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 456, Name = "Ак-Сууский айылный аймак", Code = "41708217804000",
                    CoateType = CoateType.Countryside, ParentId = 62, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 457, Name = "Александровский айылный аймак", Code = "41708217809000",
                    CoateType = CoateType.Countryside, ParentId = 62, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 458, Name = "Беш-Терекский айылный аймак", Code = "41708217811000",
                    CoateType = CoateType.Countryside, ParentId = 62, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 459, Name = "Беловодский айылный аймак", Code = "41708217813000",
                    CoateType = CoateType.Countryside, ParentId = 62, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 460, Name = "Петровский айылный аймак", Code = "41708217824000",
                    CoateType = CoateType.Countryside, ParentId = 62, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 461, Name = "Первомайский айылный аймак", Code = "41708217828000",
                    CoateType = CoateType.Countryside, ParentId = 62, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 462, Name = "Предтеченский айылный аймак", Code = "41708217832000",
                    CoateType = CoateType.Countryside, ParentId = 62, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 463, Name = "Садовский айылный аймак", Code = "41708217837000",
                    CoateType = CoateType.Countryside, ParentId = 62, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 464, Name = "Сретенский айылный аймак", Code = "41708217840000",
                    CoateType = CoateType.Countryside, ParentId = 62, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 465, Name = "Телекский айылный аймак", Code = "41708217842000",
                    CoateType = CoateType.Countryside, ParentId = 62, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 466, Name = "Целинный айылный аймак", Code = "41708217845000",
                    CoateType = CoateType.Countryside, ParentId = 62, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 467, Name = "Чапаевский айылный аймак", Code = "41708217849000",
                    CoateType = CoateType.Countryside, ParentId = 62, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 468, Name = "Вознесеновский айылный аймак", Code = "41708219811000",
                    CoateType = CoateType.Countryside, ParentId = 63, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 469, Name = "Кюрпюльдекский айылный аймак", Code = "41708219820000",
                    CoateType = CoateType.Countryside, ParentId = 63, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 470, Name = "Ортоевский айылный аймак", Code = "41708219830000",
                    CoateType = CoateType.Countryside, ParentId = 63, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 471, Name = "Айылный аймак  Курама", Code = "41708219836000",
                    CoateType = CoateType.Countryside, ParentId = 63, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 472, Name = "Фрунзенский айылный аймак", Code = "41708219849000",
                    CoateType = CoateType.Countryside, ParentId = 63, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 473, Name = "Чалдыбарский айылный аймак", Code = "41708219855000",
                    CoateType = CoateType.Countryside, ParentId = 63, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 474, Name = "Ат-Башынский айылный аймак", Code = "41708222805000",
                    CoateType = CoateType.Countryside, ParentId = 64, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 475, Name = "Тош-Булакский айылный аймак", Code = "41708222809000",
                    CoateType = CoateType.Countryside, ParentId = 64, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 476, Name = "Военно-Антоновский айылный аймак", Code = "41708222813000",
                    CoateType = CoateType.Countryside, ParentId = 64, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 477, Name = "Гавриловский айылный аймак", Code = "41708222817000",
                    CoateType = CoateType.Countryside, ParentId = 64, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 478, Name = "Джаны-Джерский айылный аймак", Code = "41708222822000",
                    CoateType = CoateType.Countryside, ParentId = 64, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 479, Name = "Джаны-Пахтинский айылный аймак", Code = "41708222826000",
                    CoateType = CoateType.Countryside, ParentId = 64, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 480, Name = "Камышановский айылный аймак", Code = "41708222828000",
                    CoateType = CoateType.Countryside, ParentId = 64, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 481, Name = "Асылбашский айылный аймак", Code = "41708222829000",
                    CoateType = CoateType.Countryside, ParentId = 64, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 482, Name = "Кунтууский айылный аймак", Code = "41708222832000",
                    CoateType = CoateType.Countryside, ParentId = 64, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 483, Name = "Айылный аймак  им. Крупской", Code = "41708222834000",
                    CoateType = CoateType.Countryside, ParentId = 64, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 484, Name = "Кызыл-Тууский айылный аймак", Code = "41708222838000",
                    CoateType = CoateType.Countryside, ParentId = 64, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 485, Name = "Нижнечуйский айылный аймак", Code = "41708222846000",
                    CoateType = CoateType.Countryside, ParentId = 64, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 486, Name = "Новопавловский айылный аймак", Code = "41708222849000",
                    CoateType = CoateType.Countryside, ParentId = 64, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 487, Name = "Сазский айылный аймак", Code = "41708222852000",
                    CoateType = CoateType.Countryside, ParentId = 64, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 488, Name = "Орокский айылный аймак", Code = "41708222856000",
                    CoateType = CoateType.Countryside, ParentId = 64, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 489, Name = "Первомайский айылный аймак", Code = "41708222860000",
                    CoateType = CoateType.Countryside, ParentId = 64, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 490, Name = "Сокулукский айылный аймак", Code = "41708222865000",
                    CoateType = CoateType.Countryside, ParentId = 64, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 491, Name = "Фрунзенский айылный аймак", Code = "41708222869000",
                    CoateType = CoateType.Countryside, ParentId = 64, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 492, Name = "Айылный аймак  им.  Кайназаровой", Code = "41708222872000",
                    CoateType = CoateType.Countryside, ParentId = 64, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 493, Name = "Ак-Бешимский айылный аймак", Code = "41708223804000",
                    CoateType = CoateType.Countryside, ParentId = 65, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 494, Name = "Буранинский айылный аймак", Code = "41708223809000",
                    CoateType = CoateType.Countryside, ParentId = 65, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 495, Name = "Искринский айылный аймак", Code = "41708223812000",
                    CoateType = CoateType.Countryside, ParentId = 65, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 496, Name = "Ибраимовский айылный аймак", Code = "41708223815000",
                    CoateType = CoateType.Countryside, ParentId = 65, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 497, Name = "Кегетинский айылный аймак", Code = "41708223820000",
                    CoateType = CoateType.Countryside, ParentId = 65, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 498, Name = "Кош-Коргонский айылный аймак", Code = "41708223825000",
                    CoateType = CoateType.Countryside, ParentId = 65, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 499, Name = "Онбир-Джылгинский айылный аймак", Code = "41708223840000",
                    CoateType = CoateType.Countryside, ParentId = 65, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 500, Name = "Сайлыкский айылный аймак", Code = "41708223845000",
                    CoateType = CoateType.Countryside, ParentId = 65, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 501, Name = "Чуйский айылный аймак", Code = "41708223863000",
                    CoateType = CoateType.Countryside, ParentId = 65, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 502, Name = "Шамшынский айылный аймак", Code = "41708223868000",
                    CoateType = CoateType.Countryside, ParentId = 65, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 503, Name = "Ак-Кудукский айылный аймак", Code = "41708206803000",
                    CoateType = CoateType.Countryside, ParentId = 58, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 504, Name = "Бирдикский айылный аймак", Code = "41708206810000",
                    CoateType = CoateType.Countryside, ParentId = 58, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 505, Name = "Ивановский айылный аймак", Code = "41708206812000",
                    CoateType = CoateType.Countryside, ParentId = 58, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 506, Name = "Нурманбетский айылный аймак", Code = "41708206816000",
                    CoateType = CoateType.Countryside, ParentId = 58, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 507, Name = "Джээкский айылный аймак", Code = "41708206818000",
                    CoateType = CoateType.Countryside, ParentId = 58, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 508, Name = "Кен-Булунский айылный аймак", Code = "41708206820000",
                    CoateType = CoateType.Countryside, ParentId = 58, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 509, Name = "Интернациональный айылный аймак", Code = "41708206821000",
                    CoateType = CoateType.Countryside, ParentId = 58, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 510, Name = "Иссык-Атинский айылный аймак", Code = "41708206822000",
                    CoateType = CoateType.Countryside, ParentId = 58, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 511, Name = "Краснореченский айылный аймак", Code = "41708206823000",
                    CoateType = CoateType.Countryside, ParentId = 58, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 512, Name = "Логвиненковский айылный аймак", Code = "41708206836000",
                    CoateType = CoateType.Countryside, ParentId = 58, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 513, Name = "Кочкорбаевский айылный аймак", Code = "41708206838000",
                    CoateType = CoateType.Countryside, ParentId = 58, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 514, Name = "Люксембургский айылный аймак", Code = "41708206839000",
                    CoateType = CoateType.Countryside, ParentId = 58, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 515, Name = "Милянфанский айылный аймак", Code = "41708206842000",
                    CoateType = CoateType.Countryside, ParentId = 58, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 516, Name = "Сын-Ташский айылный аймак", Code = "41708206846000",
                    CoateType = CoateType.Countryside, ParentId = 58, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 517, Name = "Новопокровский айылный аймак", Code = "41708206848000",
                    CoateType = CoateType.Countryside, ParentId = 58, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 518, Name = "Юрьевский айылный аймак", Code = "41708206852000",
                    CoateType = CoateType.Countryside, ParentId = 58, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 519, Name = "Тузский айылный аймак", Code = "41708206870000",
                    CoateType = CoateType.Countryside, ParentId = 58, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 520, Name = "Узун-Кырский айылный аймак", Code = "41708206873000",
                    CoateType = CoateType.Countryside, ParentId = 58, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 521, Name = "Ак-Булун", Code = "41702205805010", CoateType = CoateType.Village, ParentId = 166,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 522, Name = "Ак-Булак", Code = "41702205805020", CoateType = CoateType.Village, ParentId = 166,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 523, Name = "Токтогул", Code = "41702205805030", CoateType = CoateType.Village, ParentId = 166,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 524, Name = "Тюрген", Code = "41702205805040", CoateType = CoateType.Village, ParentId = 166,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 525, Name = "Берю-Баш", Code = "41702205807010", CoateType = CoateType.Village, ParentId = 167,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 526, Name = "Черик", Code = "41702205807030", CoateType = CoateType.Village, ParentId = 167,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 527, Name = "Тегизчил", Code = "41702205812010", CoateType = CoateType.Village, ParentId = 168,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 528, Name = "Джаны-Арык", Code = "41702205812020", CoateType = CoateType.Village,
                    ParentId = 168, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 529, Name = "Кара-Джал", Code = "41702205812030", CoateType = CoateType.Village,
                    ParentId = 168, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 530, Name = "Боз-Булун", Code = "41702205812060", CoateType = CoateType.Village,
                    ParentId = 168, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 531, Name = "Каракол", Code = "41702205813010", CoateType = CoateType.Village, ParentId = 169,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 532, Name = "Чолпон", Code = "41702205813020", CoateType = CoateType.Village, ParentId = 169,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 533, Name = "Сары-Камыш", Code = "41702205818010", CoateType = CoateType.Village,
                    ParentId = 170, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 534, Name = "Кайырма-Арык", Code = "41702205818020", CoateType = CoateType.Village,
                    ParentId = 170, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 535, Name = "Кереге-Таш", Code = "41702205818030", CoateType = CoateType.Village,
                    ParentId = 170, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 536, Name = "Новоконстантиновка", Code = "41702205818040", CoateType = CoateType.Village,
                    ParentId = 170, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 537, Name = "Пионер", Code = "41702205818050", CoateType = CoateType.Village, ParentId = 170,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 538, Name = "Нововознесеновка", Code = "41702205825010", CoateType = CoateType.Village,
                    ParentId = 171, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 539, Name = "Боз-Учук", Code = "41702205825020", CoateType = CoateType.Village, ParentId = 171,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 540, Name = "Ичке-Джергез", Code = "41702205825030", CoateType = CoateType.Village,
                    ParentId = 171, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 541, Name = "Октябрьское", Code = "41702205832010", CoateType = CoateType.Village,
                    ParentId = 172, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 542, Name = "Джол-Колот", Code = "41702205832020", CoateType = CoateType.Village,
                    ParentId = 172, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 543, Name = "Отуз-Уул", Code = "41702205832030", CoateType = CoateType.Village, ParentId = 172,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 544, Name = "Уч-Кайнар", Code = "41702205832040", CoateType = CoateType.Village,
                    ParentId = 172, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 545, Name = "Отрадное", Code = "41702205835010", CoateType = CoateType.Village, ParentId = 173,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 546, Name = "Орлиное", Code = "41702205835020", CoateType = CoateType.Village, ParentId = 173,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 547, Name = "Шапак", Code = "41702205835030", CoateType = CoateType.Village, ParentId = 173,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 548, Name = "Ак-Чий", Code = "41702205840010", CoateType = CoateType.Village, ParentId = 174,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 549, Name = "Качыбек", Code = "41702205840020", CoateType = CoateType.Village, ParentId = 174,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 550, Name = "Кек-Джайык", Code = "41702205840030", CoateType = CoateType.Village,
                    ParentId = 174, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 551, Name = "Кызыл-Джар", Code = "41702205840040", CoateType = CoateType.Village,
                    ParentId = 174, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 552, Name = "Советское", Code = "41702205840050", CoateType = CoateType.Village,
                    ParentId = 174, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 553, Name = "Тепке", Code = "41702205844010", CoateType = CoateType.Village, ParentId = 175,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 554, Name = "Джылдыз", Code = "41702205844020", CoateType = CoateType.Village, ParentId = 175,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 555, Name = "Курбу", Code = "41702205844030", CoateType = CoateType.Village, ParentId = 175,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 556, Name = "Теплоключенка", Code = "41702205848010", CoateType = CoateType.Village,
                    ParentId = 176, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 557, Name = "Лесное", Code = "41702205848020", CoateType = CoateType.Village, ParentId = 176,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 558, Name = "Челпек", Code = "41702205850010", CoateType = CoateType.Village, ParentId = 177,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 559, Name = "Бурма-Суу", Code = "41702205850020", CoateType = CoateType.Village,
                    ParentId = 177, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 560, Name = "Таш-Кыя", Code = "41702205850030", CoateType = CoateType.Village, ParentId = 177,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 561, Name = "Энильчек", Code = "41702205852010", CoateType = CoateType.Village, ParentId = 178,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 562, Name = "Кен-Суу", Code = "41702205852020", CoateType = CoateType.Village, ParentId = 178,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 563, Name = "Койлуу", Code = "41702205852030", CoateType = CoateType.Village, ParentId = 178,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 564, Name = "Кургак", Code = "41702205852040", CoateType = CoateType.Village, ParentId = 178,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 565, Name = "Май-Саз", Code = "41702205852050", CoateType = CoateType.Village, ParentId = 178,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 566, Name = "Таш-Короо", Code = "41702205852060", CoateType = CoateType.Village,
                    ParentId = 178, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 567, Name = "Эчкили-Таш", Code = "41702205852070", CoateType = CoateType.Village,
                    ParentId = 178, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 568, Name = "Жыргалан", Code = "41702205855010", CoateType = CoateType.Village, ParentId = 179,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 569, Name = "Мундуз", Code = "41702210805010", CoateType = CoateType.Village, ParentId = 181,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 570, Name = "Ак-Дебе", Code = "41702210805020", CoateType = CoateType.Village, ParentId = 181,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 571, Name = "Ан-Остен", Code = "41702210805030", CoateType = CoateType.Village, ParentId = 181,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 572, Name = "Тилекмат", Code = "41702210805040", CoateType = CoateType.Village, ParentId = 181,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 573, Name = "Ак-Шыйрак", Code = "41702210810010", CoateType = CoateType.Village,
                    ParentId = 182, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 574, Name = "Культцентр", Code = "41702210810020", CoateType = CoateType.Village,
                    ParentId = 182, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 575, Name = "Ыштык", Code = "41702210810030", CoateType = CoateType.Village, ParentId = 182,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 576, Name = "Барскоон", Code = "41702210815010", CoateType = CoateType.Village, ParentId = 183,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 577, Name = "Каракол", Code = "41702210815020", CoateType = CoateType.Village, ParentId = 183,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 578, Name = "Кара-Сай", Code = "41702210815030", CoateType = CoateType.Village, ParentId = 183,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 579, Name = "Сеок", Code = "41702210815040", CoateType = CoateType.Village, ParentId = 183,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 580, Name = "Даркан", Code = "41702210820010", CoateType = CoateType.Village, ParentId = 184,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 581, Name = "Ак-Терек", Code = "41702210825010", CoateType = CoateType.Village, ParentId = 185,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 582, Name = "Джениш", Code = "41702210825020", CoateType = CoateType.Village, ParentId = 185,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 583, Name = "Кичи-Джаргылчак", Code = "41702210825030", CoateType = CoateType.Village,
                    ParentId = 185, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 584, Name = "Чон-Джаргылчак", Code = "41702210825040", CoateType = CoateType.Village,
                    ParentId = 185, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 585, Name = "Джети-Огуз", Code = "41702210830010", CoateType = CoateType.Village,
                    ParentId = 186, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 586, Name = "Ак-Кочкор", Code = "41702210830020", CoateType = CoateType.Village,
                    ParentId = 186, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 587, Name = "Джеле-Дебе", Code = "41702210830030", CoateType = CoateType.Village,
                    ParentId = 186, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 588, Name = "Джети-Огуз (курорт)", Code = "41702210830040", CoateType = CoateType.Village,
                    ParentId = 186, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 589, Name = "Кабак", Code = "41702210830050", CoateType = CoateType.Village, ParentId = 186,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 590, Name = "Талды-Булак", Code = "41702210830060", CoateType = CoateType.Village,
                    ParentId = 186, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 591, Name = "Чырак", Code = "41702210830070", CoateType = CoateType.Village, ParentId = 186,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 592, Name = "Алкым", Code = "41702210835010", CoateType = CoateType.Village, ParentId = 187,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 593, Name = "Джон-Булак", Code = "41702210835020", CoateType = CoateType.Village,
                    ParentId = 187, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 594, Name = "Комсомольское", Code = "41702210835030", CoateType = CoateType.Village,
                    ParentId = 187, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 595, Name = "Конкино", Code = "41702210835040", CoateType = CoateType.Village, ParentId = 187,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 596, Name = "Ырдык", Code = "41702210835050", CoateType = CoateType.Village, ParentId = 187,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 597, Name = "Липенка", Code = "41702210840010", CoateType = CoateType.Village, ParentId = 188,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 598, Name = "Богатыровка", Code = "41702210840020", CoateType = CoateType.Village,
                    ParentId = 188, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 599, Name = "Зеленый Гай", Code = "41702210840030", CoateType = CoateType.Village,
                    ParentId = 188, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 600, Name = "Ичке-Булун", Code = "41702210840040", CoateType = CoateType.Village,
                    ParentId = 188, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 601, Name = "Оргочор", Code = "41702210845010", CoateType = CoateType.Village, ParentId = 189,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 602, Name = "Боз-Бешик", Code = "41702210845020", CoateType = CoateType.Village,
                    ParentId = 189, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 603, Name = "Кургак-Айрык", Code = "41702210845030", CoateType = CoateType.Village,
                    ParentId = 189, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 604, Name = "Подгорное", Code = "41702210845040", CoateType = CoateType.Village,
                    ParentId = 189, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 605, Name = "Кызыл-Суу", Code = "41702210850010", CoateType = CoateType.Village,
                    ParentId = 190, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 606, Name = "Жалгыз-Орюк", Code = "41702210850020", CoateType = CoateType.Village,
                    ParentId = 190, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 607, Name = "Кайнар", Code = "41702210850030", CoateType = CoateType.Village, ParentId = 190,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 608, Name = "Покровская Пристань", Code = "41702210850040", CoateType = CoateType.Village,
                    ParentId = 190, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 609, Name = "Саруу", Code = "41702210855010", CoateType = CoateType.Village, ParentId = 191,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 610, Name = "Джууку", Code = "41702210855020", CoateType = CoateType.Village, ParentId = 191,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 611, Name = "Иссык-Кель", Code = "41702210855030", CoateType = CoateType.Village,
                    ParentId = 191, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 612, Name = "Светлая Поляна", Code = "41702210860010", CoateType = CoateType.Village,
                    ParentId = 192, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 613, Name = "Чон-Кызыл-Суу", Code = "41702210860020", CoateType = CoateType.Village,
                    ParentId = 192, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 614, Name = "Тамга", Code = "41702210862010", CoateType = CoateType.Village, ParentId = 193,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 615, Name = "Тосор", Code = "41702210862020", CoateType = CoateType.Village, ParentId = 193,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 616, Name = "Ананьево", Code = "41702215805010", CoateType = CoateType.Village, ParentId = 194,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 617, Name = "Кек-Дебе", Code = "41702215805020", CoateType = CoateType.Village, ParentId = 194,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 618, Name = "Чет-Байсоорун", Code = "41702215805030", CoateType = CoateType.Village,
                    ParentId = 194, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 619, Name = "Бостери", Code = "41702215808010", CoateType = CoateType.Village, ParentId = 195,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 620, Name = "Бактуу-Долоноту", Code = "41702215808020", CoateType = CoateType.Village,
                    ParentId = 195, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 621, Name = "Григорьевка", Code = "41702215810010", CoateType = CoateType.Village,
                    ParentId = 196, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 622, Name = "Григорьевская пристань", Code = "41702215810020", CoateType = CoateType.Village,
                    ParentId = 196, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 623, Name = "Кара-Ой", Code = "41702215815010", CoateType = CoateType.Village, ParentId = 197,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 624, Name = "Корумду", Code = "41702215820010", CoateType = CoateType.Village, ParentId = 198,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 625, Name = "Булан-Сегетту        ", Code = "41702215820020", CoateType = CoateType.Village,
                    ParentId = 198, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 626, Name = "Семеновка", Code = "41702215825010", CoateType = CoateType.Village,
                    ParentId = 199, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 627, Name = "Коджояр", Code = "41702215825020", CoateType = CoateType.Village, ParentId = 199,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 628, Name = "Тамчы", Code = "41702215830010", CoateType = CoateType.Village, ParentId = 200,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 629, Name = "Кош-Кель", Code = "41702215830020", CoateType = CoateType.Village, ParentId = 200,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 630, Name = "Чырпыкты", Code = "41702215830030", CoateType = CoateType.Village, ParentId = 200,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 631, Name = "Жаркынбаево", Code = "41702215835010", CoateType = CoateType.Village,
                    ParentId = 201, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 632, Name = "Кароол-Дебе", Code = "41702215835020", CoateType = CoateType.Village,
                    ParentId = 201, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 633, Name = "Темировка", Code = "41702215840010", CoateType = CoateType.Village,
                    ParentId = 202, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 634, Name = "Кашат", Code = "41702215840020", CoateType = CoateType.Village, ParentId = 202,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 635, Name = "Тору-Айгыр", Code = "41702215845010", CoateType = CoateType.Village,
                    ParentId = 203, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 636, Name = "Кызыл-Орюк", Code = "41702215845020", CoateType = CoateType.Village,
                    ParentId = 203, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 637, Name = "Сары-Камыш", Code = "41702215845030", CoateType = CoateType.Village,
                    ParentId = 203, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 638, Name = "Чон-Орюктю", Code = "41702215850010", CoateType = CoateType.Village,
                    ParentId = 204, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 639, Name = "Орто-Орюктю", Code = "41702215850020", CoateType = CoateType.Village,
                    ParentId = 204, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 640, Name = "Орюктю-Хутор", Code = "41702215850030", CoateType = CoateType.Village,
                    ParentId = 204, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 641, Name = "Чон-Сары-Ой", Code = "41702215855010", CoateType = CoateType.Village,
                    ParentId = 205, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 642, Name = "Баетовка", Code = "41702215855020", CoateType = CoateType.Village, ParentId = 205,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 643, Name = "Орнек", Code = "41702215855030", CoateType = CoateType.Village, ParentId = 205,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 644, Name = "Сары-Ой", Code = "41702215855040", CoateType = CoateType.Village, ParentId = 205,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 645, Name = "Чок-Тал", Code = "41702215855050", CoateType = CoateType.Village, ParentId = 205,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 646, Name = "Кара-Коо", Code = "41702220805010", CoateType = CoateType.Village, ParentId = 206,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 647, Name = "Ала-Баш", Code = "41702220805020", CoateType = CoateType.Village, ParentId = 206,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 648, Name = "Бар-Булак", Code = "41702220805030", CoateType = CoateType.Village,
                    ParentId = 206, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 649, Name = "Ден-Талаа", Code = "41702220805040", CoateType = CoateType.Village,
                    ParentId = 206, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 650, Name = "Комсомол", Code = "41702220805050", CoateType = CoateType.Village, ParentId = 206,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 651, Name = "Кызыл-Туу", Code = "41702220805060", CoateType = CoateType.Village,
                    ParentId = 206, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 652, Name = "Тогуз-Булак", Code = "41702220806010", CoateType = CoateType.Village,
                    ParentId = 207, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 653, Name = "Кель-Тер", Code = "41702220806020", CoateType = CoateType.Village, ParentId = 207,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 654, Name = "Конур-Олен", Code = "41702220806030", CoateType = CoateType.Village,
                    ParentId = 207, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 655, Name = "Ак-Олен", Code = "41702220807010", CoateType = CoateType.Village, ParentId = 208,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 656, Name = "Кек-Мойнок-первое", Code = "41702220807020", CoateType = CoateType.Village,
                    ParentId = 208, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 657, Name = "Кек-Мойнок-второе", Code = "41702220807030", CoateType = CoateType.Village,
                    ParentId = 208, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 658, Name = "Эшперово", Code = "41702220808010", CoateType = CoateType.Village, ParentId = 209,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 659, Name = "Ак-Сай", Code = "41702220808020", CoateType = CoateType.Village, ParentId = 209,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 660, Name = "Джер-Уй", Code = "41702220808030", CoateType = CoateType.Village, ParentId = 209,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 661, Name = "Кек-Сай", Code = "41702220808040", CoateType = CoateType.Village, ParentId = 209,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 662, Name = "Боконбаево", Code = "41702220810010", CoateType = CoateType.Village,
                    ParentId = 210, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 663, Name = "Арчалы", Code = "41702220810020", CoateType = CoateType.Village, ParentId = 210,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 664, Name = "Тон", Code = "41702220815010", CoateType = CoateType.Village, ParentId = 211,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 665, Name = "Ак-Сай", Code = "41702220815020", CoateType = CoateType.Village, ParentId = 211,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 666, Name = "Каджи-Саз", Code = "41702220815030", CoateType = CoateType.Village,
                    ParentId = 211, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 667, Name = "Терт-Куль", Code = "41702220820010", CoateType = CoateType.Village,
                    ParentId = 212, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 668, Name = "Темир-Канат", Code = "41702220820020", CoateType = CoateType.Village,
                    ParentId = 212, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 669, Name = "Туура-Суу ", Code = "41702220820030", CoateType = CoateType.Village,
                    ParentId = 212, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 670, Name = "Оттук", Code = "41702220825010", CoateType = CoateType.Village, ParentId = 213,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 671, Name = "Кара-Талаа", Code = "41702220825020", CoateType = CoateType.Village,
                    ParentId = 213, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 672, Name = "Кара-Шаар", Code = "41702220825030", CoateType = CoateType.Village,
                    ParentId = 213, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 673, Name = "Туура-Суу", Code = "41702220825040", CoateType = CoateType.Village,
                    ParentId = 213, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 674, Name = "Шор-Булак", Code = "41702220825050", CoateType = CoateType.Village,
                    ParentId = 213, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 675, Name = "Каджи-Сай", Code = "41702220828010", CoateType = CoateType.Village,
                    ParentId = 214, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 676, Name = "Мин-Булак", Code = "41702225810010", CoateType = CoateType.Village,
                    ParentId = 215, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 677, Name = "Арал", Code = "41702225810020", CoateType = CoateType.Village, ParentId = 215,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 678, Name = "Долон", Code = "41702225810030", CoateType = CoateType.Village, ParentId = 215,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 679, Name = "Кош-Дебе", Code = "41702225810040", CoateType = CoateType.Village, ParentId = 215,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 680, Name = "Сары-Дебе", Code = "41702225810050", CoateType = CoateType.Village,
                    ParentId = 215, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 681, Name = "Иссык-Кель", Code = "41702225815010", CoateType = CoateType.Village,
                    ParentId = 216, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 682, Name = "Ынтымак", Code = "41702225815020", CoateType = CoateType.Village, ParentId = 216,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 683, Name = "Кутургу", Code = "41702225835010", CoateType = CoateType.Village, ParentId = 217,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 684, Name = "Кичи-Орюктю", Code = "41702225835020", CoateType = CoateType.Village,
                    ParentId = 217, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 685, Name = "Ой-Булак", Code = "41702225835030", CoateType = CoateType.Village, ParentId = 217,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 686, Name = "Ой-Тал", Code = "41702225835040", CoateType = CoateType.Village, ParentId = 217,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 687, Name = "Михайловка", Code = "41702225841010", CoateType = CoateType.Village,
                    ParentId = 218, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 688, Name = "Тогуз-Булак", Code = "41702225847010", CoateType = CoateType.Village,
                    ParentId = 219, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 689, Name = "Сары-Булун", Code = "41702225847020", CoateType = CoateType.Village,
                    ParentId = 219, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 690, Name = "Байзак", Code = "41702225865010", CoateType = CoateType.Village, ParentId = 220,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 691, Name = "Каркыра", Code = "41702225865020", CoateType = CoateType.Village, ParentId = 220,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 692, Name = "Кен-Суу", Code = "41702225865030", CoateType = CoateType.Village, ParentId = 220,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 693, Name = "Сан-Таш", Code = "41702225865040", CoateType = CoateType.Village, ParentId = 220,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 694, Name = "Сары-Телегей", Code = "41702225865050", CoateType = CoateType.Village,
                    ParentId = 220, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 695, Name = "Балбай", Code = "41702225870010", CoateType = CoateType.Village, ParentId = 221,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 696, Name = "Кюрментю", Code = "41702225870020", CoateType = CoateType.Village, ParentId = 221,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 697, Name = "Ак-Булун", Code = "41702225873010", CoateType = CoateType.Village, ParentId = 222,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 698, Name = "Беловодское", Code = "41702225873020", CoateType = CoateType.Village,
                    ParentId = 222, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 699, Name = "Фрунзенское", Code = "41702225873030", CoateType = CoateType.Village,
                    ParentId = 222, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 700, Name = "Талды-Суу", Code = "41702225876010", CoateType = CoateType.Village,
                    ParentId = 223, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 701, Name = "Ичке-Суу", Code = "41702225876020", CoateType = CoateType.Village, ParentId = 223,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 702, Name = "Кеочю", Code = "41702225876030", CoateType = CoateType.Village, ParentId = 223,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 703, Name = "Корумду", Code = "41702225876040", CoateType = CoateType.Village, ParentId = 223,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 704, Name = "Тасма", Code = "41702225883010", CoateType = CoateType.Village, ParentId = 224,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 705, Name = "Токтоян", Code = "41702225883020", CoateType = CoateType.Village, ParentId = 224,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 706, Name = "Чон-Тогуз-Бай", Code = "41702225883030", CoateType = CoateType.Village,
                    ParentId = 224, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 707, Name = "Тюп", Code = "41702225889010", CoateType = CoateType.Village, ParentId = 225,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 708, Name = "Бирлик", Code = "41702225889020", CoateType = CoateType.Village, ParentId = 225,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 709, Name = "Шаты", Code = "41702225889030", CoateType = CoateType.Village, ParentId = 225,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 710, Name = "Чон-Таш", Code = "41702225893010", CoateType = CoateType.Village, ParentId = 226,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 711, Name = "Джылуу-Булак", Code = "41702225893020", CoateType = CoateType.Village,
                    ParentId = 226, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 712, Name = "Ак-Булак", Code = "41702225896010", CoateType = CoateType.Village, ParentId = 227,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 713, Name = "Кайырма", Code = "41708203803010", CoateType = CoateType.Village, ParentId = 416,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 714, Name = "Молдовановка", Code = "41708203803020", CoateType = CoateType.Village,
                    ParentId = 416, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 715, Name = "Мраморное", Code = "41708203805010", CoateType = CoateType.Village,
                    ParentId = 417, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 716, Name = "Рассвет", Code = "41708203805020", CoateType = CoateType.Village, ParentId = 417,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 717, Name = "Аламудун", Code = "41708203807010", CoateType = CoateType.Village, ParentId = 418,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 718, Name = "Садовое", Code = "41708203807020", CoateType = CoateType.Village, ParentId = 418,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 719, Name = "Арашан", Code = "41708203809010", CoateType = CoateType.Village, ParentId = 419,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 720, Name = "Татыр", Code = "41708203809020", CoateType = CoateType.Village, ParentId = 419,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 721, Name = "Виноградное", Code = "41708203814010", CoateType = CoateType.Village,
                    ParentId = 420, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 722, Name = "Васильевка", Code = "41708203814020", CoateType = CoateType.Village,
                    ParentId = 420, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 723, Name = "Полевое", Code = "41708203814030", CoateType = CoateType.Village, ParentId = 420,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 724, Name = "Привольное", Code = "41708203814040", CoateType = CoateType.Village,
                    ParentId = 420, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 725, Name = "Гроздь", Code = "41708203819010", CoateType = CoateType.Village, ParentId = 421,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 726, Name = "Ат-Башы", Code = "41708203819020", CoateType = CoateType.Village, ParentId = 421,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 727, Name = "Бирдик", Code = "41708203819030", CoateType = CoateType.Village, ParentId = 421,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 728, Name = "Вторая Пятилетка", Code = "41708203819040", CoateType = CoateType.Village,
                    ParentId = 421, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 729, Name = "Лесное", Code = "41708203819050", CoateType = CoateType.Village, ParentId = 421,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 730, Name = "Кара-Джыгач", Code = "41708203826010", CoateType = CoateType.Village,
                    ParentId = 422, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 731, Name = "Кок-Джар", Code = "41708203828010", CoateType = CoateType.Village, ParentId = 423,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 732, Name = "Лебединовка", Code = "41708203831010", CoateType = CoateType.Village,
                    ParentId = 424, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 733, Name = "Восток", Code = "41708203831020", CoateType = CoateType.Village, ParentId = 424,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 734, Name = "Дачное", Code = "41708203831030", CoateType = CoateType.Village, ParentId = 424,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 735, Name = "Ленинское", Code = "41708203834010", CoateType = CoateType.Village,
                    ParentId = 425, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 736, Name = "Константиновка", Code = "41708203834020", CoateType = CoateType.Village,
                    ParentId = 425, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 737, Name = "Мыкан", Code = "41708203834030", CoateType = CoateType.Village, ParentId = 425,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 738, Name = "Маевка", Code = "41708203838010", CoateType = CoateType.Village, ParentId = 426,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 739, Name = "Нижняя Ала-Арча", Code = "41708203845010", CoateType = CoateType.Village,
                    ParentId = 427, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 740, Name = "Октябрьское", Code = "41708203852010", CoateType = CoateType.Village,
                    ParentId = 428, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 741, Name = "Лубяное", Code = "41708203852020", CoateType = CoateType.Village, ParentId = 428,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 742, Name = "Чуйское", Code = "41708203852030", CoateType = CoateType.Village, ParentId = 428,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 743, Name = "Байтик", Code = "41708203855010", CoateType = CoateType.Village, ParentId = 429,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 744, Name = "Арчалы", Code = "41708203855020", CoateType = CoateType.Village, ParentId = 429,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 745, Name = "Байгельди", Code = "41708203855030", CoateType = CoateType.Village,
                    ParentId = 429, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 746, Name = "Баш-Кара-Суу", Code = "41708203855040", CoateType = CoateType.Village,
                    ParentId = 429, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 747, Name = "Кашка-Суу", Code = "41708203855050", CoateType = CoateType.Village,
                    ParentId = 429, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 748, Name = "Пригородное", Code = "41708203859010", CoateType = CoateType.Village,
                    ParentId = 430, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 749, Name = "Озерное", Code = "41708203859020", CoateType = CoateType.Village, ParentId = 430,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 750, Name = "Степное", Code = "41708203859030", CoateType = CoateType.Village, ParentId = 430,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 751, Name = "Достук", Code = "41708203859040", CoateType = CoateType.Village, ParentId = 430,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 752, Name = "Таш-Дебе", Code = "41708203864010", CoateType = CoateType.Village, ParentId = 431,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 753, Name = "Заречное", Code = "41708203864020", CoateType = CoateType.Village, ParentId = 431,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 754, Name = "Малиновка", Code = "41708203864030", CoateType = CoateType.Village,
                    ParentId = 431, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 755, Name = "Им. Суйменкула Чокморова", Code = "41708203864040", CoateType = CoateType.Village,
                    ParentId = 431, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 756, Name = "Кой-Таш", Code = "41708203866010", CoateType = CoateType.Village, ParentId = 432,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 757, Name = "Беш-Кюнгей", Code = "41708203866020", CoateType = CoateType.Village,
                    ParentId = 432, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 758, Name = "Горная Маевка", Code = "41708203866030", CoateType = CoateType.Village,
                    ParentId = 432, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 759, Name = "Кызыл-Бирдик", Code = "41708203866040", CoateType = CoateType.Village,
                    ParentId = 432, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 760, Name = "Подгорное", Code = "41708203866050", CoateType = CoateType.Village,
                    ParentId = 432, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 761, Name = "Прохладное", Code = "41708203866060", CoateType = CoateType.Village,
                    ParentId = 432, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 762, Name = "Таш-Мойнок", Code = "41708203866070", CoateType = CoateType.Village,
                    ParentId = 432, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 763, Name = "Кировское", Code = "41708206803010", CoateType = CoateType.Village,
                    ParentId = 503, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 764, Name = "Ак-Кудук", Code = "41708206803020", CoateType = CoateType.Village, ParentId = 503,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 765, Name = "Котовское", Code = "41708206803030", CoateType = CoateType.Village,
                    ParentId = 503, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 766, Name = "Первомайское", Code = "41708206803040", CoateType = CoateType.Village,
                    ParentId = 503, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 767, Name = "Хун Чи (Часть)", Code = "41708206803050", CoateType = CoateType.Village,
                    ParentId = 503, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 768, Name = "Бирдик", Code = "41708206810010", CoateType = CoateType.Village, ParentId = 504,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 769, Name = "Хун Чи (Часть)", Code = "41708206810020", CoateType = CoateType.Village,
                    ParentId = 504, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 770, Name = "Ивановка", Code = "41708206812010", CoateType = CoateType.Village, ParentId = 505,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 771, Name = "Нурманбет", Code = "41708206816010", CoateType = CoateType.Village,
                    ParentId = 506, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 772, Name = "Первомайское", Code = "41708206816020", CoateType = CoateType.Village,
                    ParentId = 506, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 773, Name = "Им. Алиаскара Токтоналиева", Code = "41708206816030",
                    CoateType = CoateType.Village, ParentId = 506, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 774, Name = "Дмитриевка", Code = "41708206818010", CoateType = CoateType.Village,
                    ParentId = 507, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 775, Name = "Им. Гагарина", Code = "41708206818020", CoateType = CoateType.Village,
                    ParentId = 507, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 776, Name = "Джээк", Code = "41708206818030", CoateType = CoateType.Village, ParentId = 507,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 777, Name = "Кен-Булун", Code = "41708206820010", CoateType = CoateType.Village,
                    ParentId = 508, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 778, Name = "Гидростроитель", Code = "41708206820020", CoateType = CoateType.Village,
                    ParentId = 508, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 779, Name = "Дружба", Code = "41708206820030", CoateType = CoateType.Village, ParentId = 508,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 780, Name = "Чолпон", Code = "41708206820040", CoateType = CoateType.Village, ParentId = 508,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 781, Name = "Интернациональное", Code = "41708206821010", CoateType = CoateType.Village,
                    ParentId = 509, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 782, Name = "Джар-Башы", Code = "41708206821020", CoateType = CoateType.Village,
                    ParentId = 509, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 783, Name = "Алмалуу", Code = "41708206822010", CoateType = CoateType.Village, ParentId = 510,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 784, Name = "Горная Серафимовка", Code = "41708206822020", CoateType = CoateType.Village,
                    ParentId = 510, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 785, Name = "Джогорку-Ичке-Суу", Code = "41708206822030", CoateType = CoateType.Village,
                    ParentId = 510, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 786, Name = "Ичке-Суу", Code = "41708206822040", CoateType = CoateType.Village, ParentId = 510,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 787, Name = "Карагай-Булак", Code = "41708206822050", CoateType = CoateType.Village,
                    ParentId = 510, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 788, Name = "Норус", Code = "41708206822060", CoateType = CoateType.Village, ParentId = 510,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 789, Name = "Таш-Башат", Code = "41708206822070", CoateType = CoateType.Village,
                    ParentId = 510, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 790, Name = "Тогуз-Булак", Code = "41708206822080", CoateType = CoateType.Village,
                    ParentId = 510, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 791, Name = "Уч-Эмчек", Code = "41708206822090", CoateType = CoateType.Village, ParentId = 510,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 792, Name = "Красная Речка", Code = "41708206823010", CoateType = CoateType.Village,
                    ParentId = 511, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 793, Name = "Новопокровка (часть)", Code = "41708206836010", CoateType = CoateType.Village,
                    ParentId = 512, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 794, Name = "Чон-Далы", Code = "41708206836020", CoateType = CoateType.Village, ParentId = 512,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 795, Name = "Кенеш", Code = "41708206838010", CoateType = CoateType.Village, ParentId = 513,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 796, Name = "Буденновка", Code = "41708206838020", CoateType = CoateType.Village,
                    ParentId = 513, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 797, Name = "Доктурбек Курманалиев", Code = "41708206838030", CoateType = CoateType.Village,
                    ParentId = 513, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 798, Name = "Люксембург", Code = "41708206839010", CoateType = CoateType.Village,
                    ParentId = 514, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 799, Name = "Киршелк", Code = "41708206839020", CoateType = CoateType.Village, ParentId = 514,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 800, Name = "Милянфан", Code = "41708206842010", CoateType = CoateType.Village, ParentId = 515,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 801, Name = "Им. Тельмана", Code = "41708206846010", CoateType = CoateType.Village,
                    ParentId = 516, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 802, Name = "Ак-Сай", Code = "41708206846020", CoateType = CoateType.Village, ParentId = 516,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 803, Name = "Жетиген", Code = "41708206846030", CoateType = CoateType.Village, ParentId = 516,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 804, Name = "Кызыл-Арык", Code = "41708206846040", CoateType = CoateType.Village,
                    ParentId = 516, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 805, Name = "Отогон", Code = "41708206846050", CoateType = CoateType.Village, ParentId = 516,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 806, Name = "Рот-Фронт", Code = "41708206846060", CoateType = CoateType.Village,
                    ParentId = 516, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 807, Name = "Советское", Code = "41708206846070", CoateType = CoateType.Village,
                    ParentId = 516, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 808, Name = "Сын-Таш", Code = "41708206846080", CoateType = CoateType.Village, ParentId = 516,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 809, Name = "Новопокровка (часть)", Code = "41708206848010", CoateType = CoateType.Village,
                    ParentId = 517, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 810, Name = "Ленинское", Code = "41708206848020", CoateType = CoateType.Village,
                    ParentId = 517, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 811, Name = "Сары-Джон", Code = "41708206848030", CoateType = CoateType.Village,
                    ParentId = 517, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 812, Name = "Юрьевка", Code = "41708206852010", CoateType = CoateType.Village, ParentId = 518,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 813, Name = "Ысык-Ата", Code = "41708206852020", CoateType = CoateType.Village, ParentId = 518,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 814, Name = "Туз", Code = "41708206870010", CoateType = CoateType.Village, ParentId = 519,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 815, Name = "Дайырбек", Code = "41708206870020", CoateType = CoateType.Village, ParentId = 519,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 816, Name = "Жайалма", Code = "41708206870030", CoateType = CoateType.Village, ParentId = 519,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 817, Name = "Нижняя Серафимовка", Code = "41708206870040", CoateType = CoateType.Village,
                    ParentId = 519, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 818, Name = "Джер-Казар", Code = "41708206873010", CoateType = CoateType.Village,
                    ParentId = 520, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 819, Name = "Дружба", Code = "41708206873020", CoateType = CoateType.Village, ParentId = 520,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 820, Name = "Нижний Норус", Code = "41708206873030", CoateType = CoateType.Village,
                    ParentId = 520, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 821, Name = "Алексеевка", Code = "41708209811010", CoateType = CoateType.Village,
                    ParentId = 433, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 822, Name = "Жайыл", Code = "41708209811020", CoateType = CoateType.Village, ParentId = 433,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 823, Name = "Ставрополовка", Code = "41708209812010", CoateType = CoateType.Village,
                    ParentId = 434, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 824, Name = "Кара-Суу", Code = "41708209812020", CoateType = CoateType.Village, ParentId = 434,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 825, Name = "Калининское", Code = "41708209814010", CoateType = CoateType.Village,
                    ParentId = 435, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 826, Name = "Калдык", Code = "41708209814020", CoateType = CoateType.Village, ParentId = 435,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 827, Name = "Кара-Дебе", Code = "41708209814030", CoateType = CoateType.Village,
                    ParentId = 435, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 828, Name = "Петропавловка", Code = "41708209817010", CoateType = CoateType.Village,
                    ParentId = 436, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 829, Name = "Кызыл-Дыйкан", Code = "41708209817020", CoateType = CoateType.Village,
                    ParentId = 436, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 830, Name = "Новониколаевка", Code = "41708209822010", CoateType = CoateType.Village,
                    ParentId = 437, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 831, Name = "Айдарбек", Code = "41708209822020", CoateType = CoateType.Village, ParentId = 437,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 832, Name = "Ак-Башат", Code = "41708209822030", CoateType = CoateType.Village, ParentId = 437,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 833, Name = "Арал", Code = "41708209822040", CoateType = CoateType.Village, ParentId = 437,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 834, Name = "Полтавка", Code = "41708209829010", CoateType = CoateType.Village, ParentId = 438,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 835, Name = "Малтабар", Code = "41708209829020", CoateType = CoateType.Village, ParentId = 438,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 836, Name = "Орто-Суу", Code = "41708209829030", CoateType = CoateType.Village, ParentId = 438,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 837, Name = "Суусамыр", Code = "41708209830010", CoateType = CoateType.Village, ParentId = 439,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 838, Name = "Кайсар", Code = "41708209830020", CoateType = CoateType.Village, ParentId = 439,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 839, Name = "Первое Мая", Code = "41708209830030", CoateType = CoateType.Village,
                    ParentId = 439, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 840, Name = "Тунук", Code = "41708209830040", CoateType = CoateType.Village, ParentId = 439,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 841, Name = "Кожомкул", Code = "41708209830050", CoateType = CoateType.Village, ParentId = 439,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 842, Name = "Каракол", Code = "41708209830060", CoateType = CoateType.Village, ParentId = 439,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 843, Name = "Кызыл-Ой", Code = "41708209830070", CoateType = CoateType.Village, ParentId = 439,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 844, Name = "Эриктуу", Code = "41708209838010", CoateType = CoateType.Village, ParentId = 440,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 845, Name = "Алтын", Code = "41708209838020", CoateType = CoateType.Village, ParentId = 440,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 846, Name = "Джекен", Code = "41708209838030", CoateType = CoateType.Village, ParentId = 440,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 847, Name = "Джон-Арык", Code = "41708209838040", CoateType = CoateType.Village,
                    ParentId = 440, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 848, Name = "Ийри-Суу", Code = "41708209838050", CoateType = CoateType.Village, ParentId = 440,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 849, Name = "Федоровка", Code = "41708209838060", CoateType = CoateType.Village,
                    ParentId = 440, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 850, Name = "Сары-Булак", Code = "41708209840010", CoateType = CoateType.Village,
                    ParentId = 441, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 851, Name = "Монолдор", Code = "41708209840020", CoateType = CoateType.Village, ParentId = 441,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 852, Name = "Сосновка", Code = "41708209844010", CoateType = CoateType.Village, ParentId = 442,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 853, Name = "Степное", Code = "41708209848010", CoateType = CoateType.Village, ParentId = 443,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 854, Name = "Бексе-Джол", Code = "41708209857010", CoateType = CoateType.Village,
                    ParentId = 444, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 855, Name = "Кайырма", Code = "41708209857020", CoateType = CoateType.Village, ParentId = 444,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 856, Name = "Бекитай", Code = "41708209857030", CoateType = CoateType.Village, ParentId = 444,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 857, Name = "Кызыл-Суу", Code = "41708213804010", CoateType = CoateType.Village,
                    ParentId = 445, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 858, Name = "Алмалуу", Code = "41708213804020", CoateType = CoateType.Village, ParentId = 445,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 859, Name = "Борду", Code = "41708213804030", CoateType = CoateType.Village, ParentId = 445,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 860, Name = "Боролдой", Code = "41708213808010", CoateType = CoateType.Village, ParentId = 446,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 861, Name = "Джаны-Алыш", Code = "41708213813010", CoateType = CoateType.Village,
                    ParentId = 447, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 862, Name = "Ильич", Code = "41708213817010", CoateType = CoateType.Village, ParentId = 448,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 863, Name = "Джаны-Джол", Code = "41708213817020", CoateType = CoateType.Village,
                    ParentId = 448, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 864, Name = "Советское", Code = "41708213817030", CoateType = CoateType.Village,
                    ParentId = 448, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 865, Name = "Кара-Булак", Code = "41708213820010", CoateType = CoateType.Village,
                    ParentId = 449, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 866, Name = "Алтымыш", Code = "41708213820020", CoateType = CoateType.Village, ParentId = 449,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 867, Name = "Бейшеке", Code = "41708213820030", CoateType = CoateType.Village, ParentId = 449,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 868, Name = "Кайынды", Code = "41708213823010", CoateType = CoateType.Village, ParentId = 450,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 869, Name = "Кароол-Добо", Code = "41708213823020", CoateType = CoateType.Village,
                    ParentId = 450, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 870, Name = "Тегирменти", Code = "41708213823030", CoateType = CoateType.Village,
                    ParentId = 450, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 871, Name = "Кичи-Кемин", Code = "41708213826010", CoateType = CoateType.Village,
                    ParentId = 451, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 872, Name = "Кызыл-Октябрь", Code = "41708213830010", CoateType = CoateType.Village,
                    ParentId = 452, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 873, Name = "Ак-Бикет", Code = "41708213830020", CoateType = CoateType.Village, ParentId = 452,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 874, Name = "Джель-Арык", Code = "41708213830030", CoateType = CoateType.Village,
                    ParentId = 452, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 875, Name = "Дорожное", Code = "41708213830040", CoateType = CoateType.Village, ParentId = 452,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 876, Name = "Кашкелен", Code = "41708213830050", CoateType = CoateType.Village, ParentId = 452,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 877, Name = "Кыз-Куо", Code = "41708213830060", CoateType = CoateType.Village, ParentId = 452,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 878, Name = "Сасык-Булак", Code = "41708213830070", CoateType = CoateType.Village,
                    ParentId = 452, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 879, Name = "Ударник", Code = "41708213830080", CoateType = CoateType.Village, ParentId = 452,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 880, Name = "Чолок", Code = "41708213830090", CoateType = CoateType.Village, ParentId = 452,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 881, Name = "Чым-Коргон", Code = "41708213839010", CoateType = CoateType.Village,
                    ParentId = 453, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 882, Name = "Новомихайловка", Code = "41708213839020", CoateType = CoateType.Village,
                    ParentId = 453, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 883, Name = "Самансур", Code = "41708213839030", CoateType = CoateType.Village, ParentId = 453,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 885, Name = "Шабдан", Code = "41708213842010", CoateType = CoateType.Village, ParentId = 454,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 886, Name = "Калмак-Ашуу", Code = "41708213842020", CoateType = CoateType.Village,
                    ParentId = 454, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 887, Name = "Кызыл-Байрак", Code = "41708213842030", CoateType = CoateType.Village,
                    ParentId = 454, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 888, Name = "Тар-Суу", Code = "41708213842040", CoateType = CoateType.Village, ParentId = 454,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 889, Name = "Торт-Куль", Code = "41708213842050", CoateType = CoateType.Village,
                    ParentId = 454, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 890, Name = "Ак-Тюз", Code = "41708213845010", CoateType = CoateType.Village, ParentId = 455,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 891, Name = "Темен-Суу", Code = "41708217804010", CoateType = CoateType.Village,
                    ParentId = 456, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 892, Name = "Ак-Башат", Code = "41708217804020", CoateType = CoateType.Village, ParentId = 456,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 893, Name = "Ак-Торпок", Code = "41708217804030", CoateType = CoateType.Village,
                    ParentId = 456, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 894, Name = "Бала-Айылчи", Code = "41708217804040", CoateType = CoateType.Village,
                    ParentId = 456, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 895, Name = "Кепер-Арык", Code = "41708217804050", CoateType = CoateType.Village,
                    ParentId = 456, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 896, Name = "Мураке", Code = "41708217804060", CoateType = CoateType.Village, ParentId = 456,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 897, Name = "Чон-Арык", Code = "41708217804070", CoateType = CoateType.Village, ParentId = 456,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 898, Name = "Александровка", Code = "41708217809010", CoateType = CoateType.Village,
                    ParentId = 457, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 899, Name = "Беш-Орюк", Code = "41708217809020", CoateType = CoateType.Village, ParentId = 457,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 900, Name = "Крупское", Code = "41708217809030", CoateType = CoateType.Village, ParentId = 457,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 901, Name = "Беш-Терек", Code = "41708217811010", CoateType = CoateType.Village,
                    ParentId = 458, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 902, Name = "Беловодское", Code = "41708217813010", CoateType = CoateType.Village,
                    ParentId = 459, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 903, Name = "Кош-Дебе", Code = "41708217813020", CoateType = CoateType.Village, ParentId = 459,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 904, Name = "Петровка", Code = "41708217824010", CoateType = CoateType.Village, ParentId = 460,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 905, Name = "Заводское", Code = "41708217824020", CoateType = CoateType.Village,
                    ParentId = 460, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 906, Name = "Кызыл-Туу", Code = "41708217824030", CoateType = CoateType.Village,
                    ParentId = 460, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 907, Name = "Ак-Суу", Code = "41708217828010", CoateType = CoateType.Village, ParentId = 461,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 908, Name = "Предтеченка", Code = "41708217832010", CoateType = CoateType.Village,
                    ParentId = 462, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 909, Name = "Ан-Арык", Code = "41708217832020", CoateType = CoateType.Village, ParentId = 462,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 910, Name = "Садовое", Code = "41708217837030", CoateType = CoateType.Village, ParentId = 463,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 911, Name = "Сретенка", Code = "41708217840010", CoateType = CoateType.Village, ParentId = 464,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 912, Name = "Большевик", Code = "41708217840020", CoateType = CoateType.Village,
                    ParentId = 464, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 913, Name = "Заря", Code = "41708217840030", CoateType = CoateType.Village, ParentId = 464,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 914, Name = "Телек", Code = "41708217842010", CoateType = CoateType.Village, ParentId = 465,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 915, Name = "Кыз-Моло", Code = "41708217845010", CoateType = CoateType.Village, ParentId = 466,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 916, Name = "Спартак", Code = "41708217849010", CoateType = CoateType.Village, ParentId = 467,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 917, Name = "Ак-Сеок", Code = "41708217849020", CoateType = CoateType.Village, ParentId = 467,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 918, Name = "Маловодное", Code = "41708217849030", CoateType = CoateType.Village,
                    ParentId = 467, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 919, Name = "Вознесеновка", Code = "41708219811010", CoateType = CoateType.Village,
                    ParentId = 468, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 920, Name = "Орто-Кайырма", Code = "41708219811020", CoateType = CoateType.Village,
                    ParentId = 468, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 921, Name = "Эркин-Сай", Code = "41708219811030", CoateType = CoateType.Village,
                    ParentId = 468, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 922, Name = "Кюрпюльдек", Code = "41708219820010", CoateType = CoateType.Village,
                    ParentId = 469, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 923, Name = "Им. Кирова", Code = "41708219820020", CoateType = CoateType.Village,
                    ParentId = 469, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 924, Name = "Ровное", Code = "41708219820030", CoateType = CoateType.Village, ParentId = 469,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 925, Name = "Им. Тельмана", Code = "41708219830010", CoateType = CoateType.Village,
                    ParentId = 470, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 926, Name = "Букара", Code = "41708219830020", CoateType = CoateType.Village, ParentId = 470,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 927, Name = "Кум-Арык", Code = "41708219830030", CoateType = CoateType.Village, ParentId = 470,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 928, Name = "Панфиловское", Code = "41708219836010", CoateType = CoateType.Village,
                    ParentId = 471, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 929, Name = "Джайылма", Code = "41708219836020", CoateType = CoateType.Village, ParentId = 471,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 930, Name = "Орто-Арык", Code = "41708219836030", CoateType = CoateType.Village,
                    ParentId = 471, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 931, Name = "Эфиронос", Code = "41708219836040", CoateType = CoateType.Village, ParentId = 471,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 932, Name = "Чалдыбар", Code = "41708219849010", CoateType = CoateType.Village, ParentId = 472,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 933, Name = "Чолок-Арык", Code = "41708219849020", CoateType = CoateType.Village,
                    ParentId = 472, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 934, Name = "Чорголу  ", Code = "41708219849030", CoateType = CoateType.Village,
                    ParentId = 472, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 935, Name = "Первомайское", Code = "41708219855010", CoateType = CoateType.Village,
                    ParentId = 473, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 936, Name = "Озерное", Code = "41708219855020", CoateType = CoateType.Village, ParentId = 473,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 937, Name = "Октябрьское", Code = "41708219855030", CoateType = CoateType.Village,
                    ParentId = 473, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 938, Name = "Ойронду", Code = "41708219855040", CoateType = CoateType.Village, ParentId = 473,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 939, Name = "Манас", Code = "41708222805010", CoateType = CoateType.Village, ParentId = 474,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 940, Name = "Ак-Джол", Code = "41708222805020", CoateType = CoateType.Village, ParentId = 474,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 941, Name = "Лесное", Code = "41708222805030", CoateType = CoateType.Village, ParentId = 474,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 942, Name = "Терт-Кель", Code = "41708222805040", CoateType = CoateType.Village,
                    ParentId = 474, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 943, Name = "Тош-Булак", Code = "41708222809010", CoateType = CoateType.Village,
                    ParentId = 475, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 944, Name = "Берюлю", Code = "41708222809020", CoateType = CoateType.Village, ParentId = 475,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 945, Name = "Четинди", Code = "41708222809030", CoateType = CoateType.Village, ParentId = 475,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 946, Name = "Военно-Антоновка", Code = "41708222813010", CoateType = CoateType.Village,
                    ParentId = 476, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 947, Name = "Гавриловка", Code = "41708222817010", CoateType = CoateType.Village,
                    ParentId = 477, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 948, Name = "Жангарач", Code = "41708222817020", CoateType = CoateType.Village, ParentId = 477,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 949, Name = "Романовка", Code = "41708222817030", CoateType = CoateType.Village,
                    ParentId = 477, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 950, Name = "Шалта", Code = "41708222817040", CoateType = CoateType.Village, ParentId = 477,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 951, Name = "Джаны-Джер", Code = "41708222822010", CoateType = CoateType.Village,
                    ParentId = 478, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 952, Name = "Верхневосточное", Code = "41708222822020", CoateType = CoateType.Village,
                    ParentId = 478, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 953, Name = "Западное", Code = "41708222822030", CoateType = CoateType.Village, ParentId = 478,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 954, Name = "Зеленое", Code = "41708222822040", CoateType = CoateType.Village, ParentId = 478,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 955, Name = "Нижневосточное", Code = "41708222822050", CoateType = CoateType.Village,
                    ParentId = 478, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 956, Name = "Джаны-Пахта", Code = "41708222826010", CoateType = CoateType.Village,
                    ParentId = 479, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 957, Name = "Ак-Кашат", Code = "41708222826020", CoateType = CoateType.Village, ParentId = 479,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 958, Name = "Заря", Code = "41708222826030", CoateType = CoateType.Village, ParentId = 479,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 959, Name = "Майское", Code = "41708222826040", CoateType = CoateType.Village, ParentId = 479,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 960, Name = "Мирный", Code = "41708222826050", CoateType = CoateType.Village, ParentId = 479,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 961, Name = "Камышановка", Code = "41708222828010", CoateType = CoateType.Village,
                    ParentId = 480, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 962, Name = "Асылбаш", Code = "41708222829010", CoateType = CoateType.Village, ParentId = 481,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 963, Name = "Кировское", Code = "41708222829020", CoateType = CoateType.Village,
                    ParentId = 481, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 964, Name = "Кунтуу", Code = "41708222832010", CoateType = CoateType.Village, ParentId = 482,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 965, Name = "Достук", Code = "41708222832020", CoateType = CoateType.Village, ParentId = 482,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 966, Name = "Малая Шалта", Code = "41708222832030", CoateType = CoateType.Village,
                    ParentId = 482, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 967, Name = "Шалта", Code = "41708222832040", CoateType = CoateType.Village, ParentId = 482,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 968, Name = "Чон-Джар", Code = "41708222832050", CoateType = CoateType.Village, ParentId = 482,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 969, Name = "Сокулук", Code = "41708222834010", CoateType = CoateType.Village, ParentId = 483,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 970, Name = "Арал Ближний", Code = "41708222834020", CoateType = CoateType.Village,
                    ParentId = 483, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 971, Name = "Арал Дальний", Code = "41708222834030", CoateType = CoateType.Village,
                    ParentId = 483, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 972, Name = "Первое Мая", Code = "41708222834040", CoateType = CoateType.Village,
                    ParentId = 483, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 973, Name = "Кызыл-Туу", Code = "41708222838010", CoateType = CoateType.Village,
                    ParentId = 484, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 974, Name = "Кара-Сакал", Code = "41708222838020", CoateType = CoateType.Village,
                    ParentId = 484, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 975, Name = "Маловодное", Code = "41708222838030", CoateType = CoateType.Village,
                    ParentId = 484, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 976, Name = "Новое", Code = "41708222838040", CoateType = CoateType.Village, ParentId = 484,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 977, Name = "Токбай", Code = "41708222838050", CoateType = CoateType.Village, ParentId = 484,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 978, Name = "Нижнечуйское", Code = "41708222846010", CoateType = CoateType.Village,
                    ParentId = 485, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 979, Name = "Мирное", Code = "41708222846020", CoateType = CoateType.Village, ParentId = 485,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 980, Name = "Садовое", Code = "41708222846030", CoateType = CoateType.Village, ParentId = 485,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 981, Name = "Северное", Code = "41708222846040", CoateType = CoateType.Village, ParentId = 485,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 982, Name = "Степное", Code = "41708222846050", CoateType = CoateType.Village, ParentId = 485,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 983, Name = "Талтак", Code = "41708222846060", CoateType = CoateType.Village, ParentId = 485,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 984, Name = "Новопавловка", Code = "41708222849010", CoateType = CoateType.Village,
                    ParentId = 486, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 985, Name = "Учкун", Code = "41708222849020", CoateType = CoateType.Village, ParentId = 486,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 986, Name = "Саз", Code = "41708222852010", CoateType = CoateType.Village, ParentId = 487,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 987, Name = "Конуш", Code = "41708222852020", CoateType = CoateType.Village, ParentId = 487,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 988, Name = "Джал", Code = "41708222856010", CoateType = CoateType.Village, ParentId = 488,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 989, Name = "Верхний Орок", Code = "41708222856020", CoateType = CoateType.Village,
                    ParentId = 488, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 990, Name = "Калтар", Code = "41708222856030", CoateType = CoateType.Village, ParentId = 488,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 991, Name = "Кашка-Баш", Code = "41708222856040", CoateType = CoateType.Village,
                    ParentId = 488, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 992, Name = "Нижний Орок", Code = "41708222856050", CoateType = CoateType.Village,
                    ParentId = 488, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 993, Name = "Плодовое", Code = "41708222856060", CoateType = CoateType.Village, ParentId = 488,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 994, Name = "Сарбан", Code = "41708222856070", CoateType = CoateType.Village, ParentId = 488,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 995, Name = "Селекционное", Code = "41708222856080", CoateType = CoateType.Village,
                    ParentId = 488, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 996, Name = "Первомайское", Code = "41708222860010", CoateType = CoateType.Village,
                    ParentId = 489, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 997, Name = "Национальное", Code = "41708222860020", CoateType = CoateType.Village,
                    ParentId = 489, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 998, Name = "Им. Панфилова", Code = "41708222860030", CoateType = CoateType.Village,
                    ParentId = 489, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 999, Name = "Сокулук", Code = "41708222865010", CoateType = CoateType.Village, ParentId = 490,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1000, Name = "Им. Фрунзе", Code = "41708222869010", CoateType = CoateType.Village,
                    ParentId = 491, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1001, Name = "Комсомольское", Code = "41708222869020", CoateType = CoateType.Village,
                    ParentId = 491, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1002, Name = "Озерное", Code = "41708222869030", CoateType = CoateType.Village, ParentId = 491,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1003, Name = "Студенческое", Code = "41708222869040", CoateType = CoateType.Village,
                    ParentId = 491, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1004, Name = "Чат-Кель", Code = "41708222872010", CoateType = CoateType.Village,
                    ParentId = 492, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1005, Name = "Белек", Code = "41708222872020", CoateType = CoateType.Village, ParentId = 492,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1006, Name = "Тюз", Code = "41708222872030", CoateType = CoateType.Village, ParentId = 492,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1007, Name = "Ак-Бешим", Code = "41708223804010", CoateType = CoateType.Village,
                    ParentId = 493, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1008, Name = "Джаны-Джол", Code = "41708223804020", CoateType = CoateType.Village,
                    ParentId = 493, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1009, Name = "Калыгул", Code = "41708223804030", CoateType = CoateType.Village, ParentId = 493,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1010, Name = "Ден-Арык", Code = "41708223809010", CoateType = CoateType.Village,
                    ParentId = 494, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1011, Name = "Алга", Code = "41708223809020", CoateType = CoateType.Village, ParentId = 494,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1012, Name = "Бурана", Code = "41708223809030", CoateType = CoateType.Village, ParentId = 494,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1013, Name = "Мээнеткеч", Code = "41708223809040", CoateType = CoateType.Village,
                    ParentId = 494, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1014, Name = "Кара-Дебе", Code = "41708223812010", CoateType = CoateType.Village,
                    ParentId = 495, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1015, Name = "Восточное", Code = "41708223812020", CoateType = CoateType.Village,
                    ParentId = 495, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1016, Name = "Джаны-Турмуш", Code = "41708223812030", CoateType = CoateType.Village,
                    ParentId = 495, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1017, Name = "Железнодорожное", Code = "41708223812040", CoateType = CoateType.Village,
                    ParentId = 495, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1018, Name = "Искра", Code = "41708223812050", CoateType = CoateType.Village, ParentId = 495,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1019, Name = "Кошой", Code = "41708223815010", CoateType = CoateType.Village, ParentId = 496,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1020, Name = "Кара-Ой", Code = "41708223815020", CoateType = CoateType.Village, ParentId = 496,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1021, Name = "Кызыл-Аскер", Code = "41708223815030", CoateType = CoateType.Village,
                    ParentId = 496, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1022, Name = "Им. Ленина", Code = "41708223815040", CoateType = CoateType.Village,
                    ParentId = 496, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1023, Name = "Ленин-Джол", Code = "41708223815050", CoateType = CoateType.Village,
                    ParentId = 496, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1024, Name = "Талды-Булак", Code = "41708223815060", CoateType = CoateType.Village,
                    ParentId = 496, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1025, Name = "Кегети", Code = "41708223820010", CoateType = CoateType.Village, ParentId = 497,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1026, Name = "Арпа-Тектир", Code = "41708223820020", CoateType = CoateType.Village,
                    ParentId = 497, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1027, Name = "Акматбек", Code = "41708223820030", CoateType = CoateType.Village,
                    ParentId = 497, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1028, Name = "Советское", Code = "41708223820040", CoateType = CoateType.Village,
                    ParentId = 497, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1029, Name = "Им. Чапаева", Code = "41708223820050", CoateType = CoateType.Village,
                    ParentId = 497, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1030, Name = "Кош-Коргон", Code = "41708223825010", CoateType = CoateType.Village,
                    ParentId = 498, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1031, Name = "Прогресс", Code = "41708223840010", CoateType = CoateType.Village,
                    ParentId = 499, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1032, Name = "Кайырма", Code = "41708223840020", CoateType = CoateType.Village, ParentId = 499,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1033, Name = "Маданият", Code = "41708223840030", CoateType = CoateType.Village,
                    ParentId = 499, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1034, Name = "Онбир-Джылга", Code = "41708223840040", CoateType = CoateType.Village,
                    ParentId = 499, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1035, Name = "Сайлык", Code = "41708223845010", CoateType = CoateType.Village, ParentId = 500,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1036, Name = "Виноградное", Code = "41708223845020", CoateType = CoateType.Village,
                    ParentId = 500, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1037, Name = "Джаны-Чек", Code = "41708223845030", CoateType = CoateType.Village,
                    ParentId = 500, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1038, Name = "Чуй", Code = "41708223863010", CoateType = CoateType.Village, ParentId = 501,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1039, Name = "Арал", Code = "41708223863020", CoateType = CoateType.Village, ParentId = 501,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1040, Name = "Садовое", Code = "41708223863030", CoateType = CoateType.Village, ParentId = 501,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1041, Name = "Шамшы", Code = "41708223868010", CoateType = CoateType.Village, ParentId = 502,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1042, Name = "Карагул", Code = "41708223868020", CoateType = CoateType.Village, ParentId = 502,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1043, Name = "Кош-Кашат", Code = "41708223868030", CoateType = CoateType.Village,
                    ParentId = 502, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1044, Name = "Чон-Джар", Code = "41708223868040", CoateType = CoateType.Village,
                    ParentId = 502, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1045, Name = "Жанырык", Code = "41705214812010", CoateType = CoateType.Village, ParentId = 67,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1046, Name = "Тунук-Суу", Code = "41705214812020", CoateType = CoateType.Village,
                    ParentId = 67, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1047, Name = "Кан", Code = "41705214812030", CoateType = CoateType.Village, ParentId = 67,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1048, Name = "Табылгы", Code = "41705214812040", CoateType = CoateType.Village, ParentId = 67,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1049, Name = "Кайынды", Code = "41705214812050", CoateType = CoateType.Village, ParentId = 67,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1050, Name = "Сары-Талаа", Code = "41705214812060", CoateType = CoateType.Village,
                    ParentId = 67, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1051, Name = "Коргон-Таш", Code = "41705214812070", CoateType = CoateType.Village,
                    ParentId = 67, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1052, Name = "Джаны-Джер", Code = "41705214812080", CoateType = CoateType.Village,
                    ParentId = 67, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1053, Name = "Чек", Code = "41705214812090", CoateType = CoateType.Village, ParentId = 67,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1054, Name = "Ак-Оток", Code = "41705214814020", CoateType = CoateType.Village, ParentId = 68,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1055, Name = "Ак-Турпак", Code = "41705214814030", CoateType = CoateType.Village,
                    ParentId = 68, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1056, Name = "Зар-Таш", Code = "41705214814040", CoateType = CoateType.Village, ParentId = 68,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1057, Name = "Чон-Гара", Code = "41705214814050", CoateType = CoateType.Village, ParentId = 68,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1058, Name = "Чон-Талаа", Code = "41705214814060", CoateType = CoateType.Village,
                    ParentId = 68, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1059, Name = "Кара-Бак", Code = "41705214823010", CoateType = CoateType.Village, ParentId = 69,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1060, Name = "Достук", Code = "41705214823030", CoateType = CoateType.Village, ParentId = 69,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1061, Name = "Кызыл-Бель", Code = "41705214823040", CoateType = CoateType.Village,
                    ParentId = 69, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1062, Name = "Чет-Кызыл", Code = "41705214823050", CoateType = CoateType.Village,
                    ParentId = 69, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1063, Name = "Зардалы", Code = "41705214823060", CoateType = CoateType.Village, ParentId = 69,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1064, Name = "Добо", Code = "41705214823070", CoateType = CoateType.Village, ParentId = 69,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1065, Name = "Бай Кара-Бак", Code = "41705214823080", CoateType = CoateType.Village,
                    ParentId = 69, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1066, Name = "Бужум", Code = "41705214824010", CoateType = CoateType.Village, ParentId = 70,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1067, Name = "Кара-Булак", Code = "41705214824030", CoateType = CoateType.Village,
                    ParentId = 70, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1068, Name = "Таян", Code = "41705214835010", CoateType = CoateType.Village, ParentId = 71,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1069, Name = "Газ", Code = "41705214835020", CoateType = CoateType.Village, ParentId = 71,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1070, Name = "Кыштут", Code = "41705214835030", CoateType = CoateType.Village, ParentId = 71,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1071, Name = "Сай", Code = "41705214835040", CoateType = CoateType.Village, ParentId = 71,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1072, Name = "Согмент", Code = "41705214835050", CoateType = CoateType.Village, ParentId = 71,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1073, Name = "Чарбак", Code = "41705214835060", CoateType = CoateType.Village, ParentId = 71,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1074, Name = "Самаркандык", Code = "41705214846010", CoateType = CoateType.Village,
                    ParentId = 72, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1075, Name = "Джаны-Бак", Code = "41705214846050", CoateType = CoateType.Village,
                    ParentId = 72, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1076, Name = "Паскы-Арык", Code = "41705214846080", CoateType = CoateType.Village,
                    ParentId = 72, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1077, Name = "Мин-Орук", Code = "41705214846090", CoateType = CoateType.Village, ParentId = 72,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1078, Name = "Ак-Сай", Code = "41705214848010", CoateType = CoateType.Village, ParentId = 73,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1079, Name = "Кек-Таш", Code = "41705214848020", CoateType = CoateType.Village, ParentId = 73,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1080, Name = "Уч-Дебе", Code = "41705214848030", CoateType = CoateType.Village, ParentId = 73,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1081, Name = "Капчыгай", Code = "41705214848040", CoateType = CoateType.Village, ParentId = 73,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1082, Name = "Таштумшук", Code = "41705214848050", CoateType = CoateType.Village,
                    ParentId = 73, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1083, Name = "Ак-Татыр", Code = "41705214849010", CoateType = CoateType.Village, ParentId = 74,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1084, Name = "Рават", Code = "41705214849020", CoateType = CoateType.Village, ParentId = 74,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1085, Name = "Говсувар", Code = "41705214849030", CoateType = CoateType.Village, ParentId = 74,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1086, Name = "Боз-Адыр", Code = "41705214852010", CoateType = CoateType.Village, ParentId = 75,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1087, Name = "Апкан", Code = "41705214852020", CoateType = CoateType.Village, ParentId = 75,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1088, Name = "Беджей", Code = "41705214852030", CoateType = CoateType.Village, ParentId = 75,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1089, Name = "Кара-Токой", Code = "41705214852040", CoateType = CoateType.Village,
                    ParentId = 75, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1090, Name = "Айгуль-Таш", Code = "41705214852050", CoateType = CoateType.Village,
                    ParentId = 75, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1091, Name = "Ак-Суу", Code = "41705236802010", CoateType = CoateType.Village, ParentId = 89,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1092, Name = "Алга", Code = "41705236802020", CoateType = CoateType.Village, ParentId = 89,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1093, Name = "Джениш", Code = "41705236802030", CoateType = CoateType.Village, ParentId = 89,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1094, Name = "Суу-Башы", Code = "41705236802040", CoateType = CoateType.Village, ParentId = 89,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1095, Name = "Бешкент", Code = "41705236804010", CoateType = CoateType.Village, ParentId = 90,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1096, Name = "Им. Карла Маркса", Code = "41705236804040", CoateType = CoateType.Village,
                    ParentId = 90, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1097, Name = "Кайрагач", Code = "41705236804050", CoateType = CoateType.Village, ParentId = 90,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1098, Name = "50 лет СССР", Code = "41705236804080", CoateType = CoateType.Village,
                    ParentId = 90, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1099, Name = "Эски-Оочу", Code = "41705236804090", CoateType = CoateType.Village,
                    ParentId = 90, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1100, Name = "Маргун", Code = "41705236806010", CoateType = CoateType.Village, ParentId = 91,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1101, Name = "Чурбек", Code = "41705236806020", CoateType = CoateType.Village, ParentId = 91,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1102, Name = "Дархум", Code = "41705236806030", CoateType = CoateType.Village, ParentId = 91,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1103, Name = "Даргаз", Code = "41705236806040", CoateType = CoateType.Village, ParentId = 91,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1104, Name = "Центральное", Code = "41705236808010", CoateType = CoateType.Village,
                    ParentId = 92, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1105, Name = "Арка", Code = "41705236808020", CoateType = CoateType.Village, ParentId = 92,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1106, Name = "Достук", Code = "41705236808030", CoateType = CoateType.Village, ParentId = 92,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1107, Name = "Коргон", Code = "41705236816010", CoateType = CoateType.Village, ParentId = 93,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1108, Name = "Кара-Суу", Code = "41705236816020", CoateType = CoateType.Village, ParentId = 93,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1109, Name = "Лейлек", Code = "41705236816030", CoateType = CoateType.Village, ParentId = 93,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1110, Name = "Чуянчы", Code = "41705236816040", CoateType = CoateType.Village, ParentId = 93,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1111, Name = "Ак-Терек", Code = "41705236816050", CoateType = CoateType.Village, ParentId = 93,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1112, Name = "Катран", Code = "41705236818010", CoateType = CoateType.Village, ParentId = 94,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1113, Name = "Джаны-Турмуш", Code = "41705236818020", CoateType = CoateType.Village,
                    ParentId = 94, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1114, Name = "Озгерюш", Code = "41705236818030", CoateType = CoateType.Village, ParentId = 94,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1115, Name = "Кулунду", Code = "41705236825010", CoateType = CoateType.Village, ParentId = 95,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1116, Name = "Булак-Башы", Code = "41705236825020", CoateType = CoateType.Village,
                    ParentId = 95, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1117, Name = "Интернациональное", Code = "41705236825030", CoateType = CoateType.Village,
                    ParentId = 95, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1118, Name = "Коммунизм", Code = "41705236825040", CoateType = CoateType.Village,
                    ParentId = 95, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1119, Name = "Им. Ленина", Code = "41705236825050", CoateType = CoateType.Village,
                    ParentId = 95, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1120, Name = "Андарак", Code = "41705236836010", CoateType = CoateType.Village, ParentId = 96,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1121, Name = "Искра", Code = "41705236836020", CoateType = CoateType.Village, ParentId = 96,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1122, Name = "Кек-Таш", Code = "41705236836030", CoateType = CoateType.Village, ParentId = 96,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1123, Name = "Коммуна", Code = "41705236836040", CoateType = CoateType.Village, ParentId = 96,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1124, Name = "Тогуз-Булак", Code = "41705236842010", CoateType = CoateType.Village,
                    ParentId = 97, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1125, Name = "Ай-Кол", Code = "41705236842020", CoateType = CoateType.Village, ParentId = 97,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1126, Name = "Кара-Булак", Code = "41705236842030", CoateType = CoateType.Village,
                    ParentId = 97, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1127, Name = "Маданият", Code = "41705236842040", CoateType = CoateType.Village, ParentId = 97,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1128, Name = "50 лет Киргизии", Code = "41705236842050", CoateType = CoateType.Village,
                    ParentId = 97, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1129, Name = "Им. Чапаева", Code = "41705236842060", CoateType = CoateType.Village,
                    ParentId = 97, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1130, Name = "Жаны-Жер", Code = "41705258804010", CoateType = CoateType.Village, ParentId = 76,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1131, Name = "Ак-Турпак", Code = "41705258804020", CoateType = CoateType.Village,
                    ParentId = 76, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1132, Name = "Джаны-Джер", Code = "41705258804030", CoateType = CoateType.Village,
                    ParentId = 76, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1133, Name = "Калача", Code = "41705258804040", CoateType = CoateType.Village, ParentId = 76,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1134, Name = "Кара-Тумшук", Code = "41705258804050", CoateType = CoateType.Village,
                    ParentId = 76, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1135, Name = "Кызыл-Коргон", Code = "41705258804060", CoateType = CoateType.Village,
                    ParentId = 76, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1136, Name = "Отукчу", Code = "41705258804070", CoateType = CoateType.Village, ParentId = 76,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1137, Name = "Сары-Камыш", Code = "41705258804080", CoateType = CoateType.Village,
                    ParentId = 76, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1138, Name = "Токой", Code = "41705258804090", CoateType = CoateType.Village, ParentId = 76,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1139, Name = "Чогорок", Code = "41705258804100", CoateType = CoateType.Village, ParentId = 76,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1140, Name = "Чон-Кара", Code = "41705258804110", CoateType = CoateType.Village, ParentId = 76,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1141, Name = "Жаш-Тилек", Code = "41705258804120", CoateType = CoateType.Village,
                    ParentId = 76, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1142, Name = "Орукзар", Code = "41705258804130", CoateType = CoateType.Village, ParentId = 76,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1143, Name = "Мин-Чынар", Code = "41705258804140", CoateType = CoateType.Village,
                    ParentId = 76, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1144, Name = "Келечек", Code = "41705258804150", CoateType = CoateType.Village, ParentId = 76,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1145, Name = "Алга", Code = "41705258808010", CoateType = CoateType.Village, ParentId = 77,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1146, Name = "Адыр", Code = "41705258808020", CoateType = CoateType.Village, ParentId = 77,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1147, Name = "Бексе", Code = "41705258808030", CoateType = CoateType.Village, ParentId = 77,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1148, Name = "Мыргылжек", Code = "41705258808080", CoateType = CoateType.Village,
                    ParentId = 77, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1149, Name = "Шак-Шак", Code = "41705258808090", CoateType = CoateType.Village, ParentId = 77,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1150, Name = "Шыбран", Code = "41705258808100", CoateType = CoateType.Village, ParentId = 77,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1151, Name = "Чункур-Кыштак", Code = "41705258808110", CoateType = CoateType.Village,
                    ParentId = 77, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1152, Name = "Жаны-Чек", Code = "41705258808120", CoateType = CoateType.Village, ParentId = 77,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1153, Name = "Ормош", Code = "41705258812010", CoateType = CoateType.Village, ParentId = 78,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1154, Name = "Бель", Code = "41705258812020", CoateType = CoateType.Village, ParentId = 78,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1155, Name = "Джал", Code = "41705258812030", CoateType = CoateType.Village, ParentId = 78,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1156, Name = "Джаны-Коргон", Code = "41705258812040", CoateType = CoateType.Village,
                    ParentId = 78, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1157, Name = "Кичи-Айдаркен", Code = "41705258812050", CoateType = CoateType.Village,
                    ParentId = 78, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1158, Name = "Моло", Code = "41705258812060", CoateType = CoateType.Village, ParentId = 78,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1159, Name = "Сур", Code = "41705258812070", CoateType = CoateType.Village, ParentId = 78,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1160, Name = "Сырт", Code = "41705258812080", CoateType = CoateType.Village, ParentId = 78,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1161, Name = "Тескей", Code = "41705258812090", CoateType = CoateType.Village, ParentId = 78,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1162, Name = "Чечме", Code = "41705258812100", CoateType = CoateType.Village, ParentId = 78,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1163, Name = "Эшме", Code = "41705258812110", CoateType = CoateType.Village, ParentId = 78,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1164, Name = "Кара-Дебе", Code = "41705258819010", CoateType = CoateType.Village,
                    ParentId = 79, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1165, Name = "Олагыш", Code = "41705258819020", CoateType = CoateType.Village, ParentId = 79,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1166, Name = "Какыр", Code = "41705258819030", CoateType = CoateType.Village, ParentId = 79,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1167, Name = "Кожо", Code = "41705258819040", CoateType = CoateType.Village, ParentId = 79,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1168, Name = "Кон", Code = "41705258819050", CoateType = CoateType.Village, ParentId = 79,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1169, Name = "Алыш", Code = "41705258819060", CoateType = CoateType.Village, ParentId = 79,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1170, Name = "Таш-Коргон", Code = "41705258819070", CoateType = CoateType.Village,
                    ParentId = 79, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1171, Name = "Лесхоз", Code = "41705258819080", CoateType = CoateType.Village, ParentId = 79,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1172, Name = "Кызыл-Булак", Code = "41705258825010", CoateType = CoateType.Village,
                    ParentId = 80, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1173, Name = "Ак-Кия", Code = "41705258825020", CoateType = CoateType.Village, ParentId = 80,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1174, Name = "Гайрат", Code = "41705258825030", CoateType = CoateType.Village, ParentId = 80,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1175, Name = "Джалгыз-Булак", Code = "41705258825040", CoateType = CoateType.Village,
                    ParentId = 80, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1176, Name = "Кара-Оот", Code = "41705258825050", CoateType = CoateType.Village, ParentId = 80,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1177, Name = "Кара-Шоро", Code = "41705258825060", CoateType = CoateType.Village,
                    ParentId = 80, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1178, Name = "Кескен-Таш", Code = "41705258825070", CoateType = CoateType.Village,
                    ParentId = 80, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1179, Name = "Кетерме", Code = "41705258825080", CoateType = CoateType.Village, ParentId = 80,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1180, Name = "Тамаша", Code = "41705258825090", CoateType = CoateType.Village, ParentId = 80,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1181, Name = "Лангар", Code = "41705258825100", CoateType = CoateType.Village, ParentId = 80,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1182, Name = "Кара-Джыгач", Code = "41705258830010", CoateType = CoateType.Village,
                    ParentId = 81, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1183, Name = "Аустан", Code = "41705258830020", CoateType = CoateType.Village, ParentId = 81,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1184, Name = "Кара-Кыштак", Code = "41705258830030", CoateType = CoateType.Village,
                    ParentId = 81, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1185, Name = "Кароол", Code = "41705258830040", CoateType = CoateType.Village, ParentId = 81,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1186, Name = "Кереге-Таш", Code = "41705258830050", CoateType = CoateType.Village,
                    ParentId = 81, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1187, Name = "Майдан", Code = "41705258830060", CoateType = CoateType.Village, ParentId = 81,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1188, Name = "Пум", Code = "41705258830070", CoateType = CoateType.Village, ParentId = 81,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1189, Name = "Кара-Добо", Code = "41705258830080", CoateType = CoateType.Village,
                    ParentId = 81, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1190, Name = "Исфайрам", Code = "41705258830090", CoateType = CoateType.Village, ParentId = 81,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1191, Name = "Сары-Алтын", Code = "41705258830100", CoateType = CoateType.Village,
                    ParentId = 81, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1192, Name = "Бак", Code = "41705258830110", CoateType = CoateType.Village, ParentId = 81,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1193, Name = "Акимбек", Code = "41705258830120", CoateType = CoateType.Village, ParentId = 81,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1194, Name = "Жаны-Абад", Code = "41705258830130", CoateType = CoateType.Village,
                    ParentId = 81, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1195, Name = "Марказ", Code = "41705258834010", CoateType = CoateType.Village, ParentId = 82,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1196, Name = "Арпа-Сай", Code = "41705258834020", CoateType = CoateType.Village, ParentId = 82,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1197, Name = "Достук", Code = "41705258834030", CoateType = CoateType.Village, ParentId = 82,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1198, Name = "Кек-Талаа", Code = "41705258834050", CoateType = CoateType.Village,
                    ParentId = 82, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1199, Name = "Маяк", Code = "41705258834060", CoateType = CoateType.Village, ParentId = 82,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1200, Name = "Пылдырак", Code = "41705258834070", CoateType = CoateType.Village, ParentId = 82,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1201, Name = "Орозбеково", Code = "41705258842010", CoateType = CoateType.Village,
                    ParentId = 83, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1202, Name = "Кулду", Code = "41705258842020", CoateType = CoateType.Village, ParentId = 83,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1203, Name = "Уч-Коргон", Code = "41705258849010", CoateType = CoateType.Village,
                    ParentId = 84, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1204, Name = "Валакиш", Code = "41705258849020", CoateType = CoateType.Village, ParentId = 84,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1205, Name = "Какыр", Code = "41705258849030", CoateType = CoateType.Village, ParentId = 84,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1206, Name = "Калача", Code = "41705258849040", CoateType = CoateType.Village, ParentId = 84,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1207, Name = "Калтак", Code = "41705258849050", CoateType = CoateType.Village, ParentId = 84,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1208, Name = "Сулайманабад", Code = "41705258849060", CoateType = CoateType.Village,
                    ParentId = 84, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1209, Name = "Разъезд", Code = "41705258849070", CoateType = CoateType.Village, ParentId = 84,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1210, Name = "Сухана", Code = "41705258849080", CoateType = CoateType.Village, ParentId = 84,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1211, Name = "Чаувай", Code = "41705258849090", CoateType = CoateType.Village, ParentId = 84,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1212, Name = "Боз", Code = "41705258849100", CoateType = CoateType.Village, ParentId = 84,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1213, Name = "Камбарабад", Code = "41705258849110", CoateType = CoateType.Village,
                    ParentId = 84, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1214, Name = "Тажик-Кыштак", Code = "41705258849120", CoateType = CoateType.Village,
                    ParentId = 84, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1215, Name = "Халмион", Code = "41705258860010", CoateType = CoateType.Village, ParentId = 85,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1216, Name = "Баймаала", Code = "41705258860020", CoateType = CoateType.Village, ParentId = 85,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1217, Name = "Гулдуромо", Code = "41705258860030", CoateType = CoateType.Village,
                    ParentId = 85, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1218, Name = "Джаны-Айыл", Code = "41705258860040", CoateType = CoateType.Village,
                    ParentId = 85, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1219, Name = "Джошук", Code = "41705258860050", CoateType = CoateType.Village, ParentId = 85,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1220, Name = "Ирилеш", Code = "41705258860060", CoateType = CoateType.Village, ParentId = 85,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1221, Name = "Кек-Тал", Code = "41705258860070", CoateType = CoateType.Village, ParentId = 85,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1222, Name = "Курулуш", Code = "41705258860080", CoateType = CoateType.Village, ParentId = 85,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1223, Name = "Ноогардан", Code = "41705258860090", CoateType = CoateType.Village,
                    ParentId = 85, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1224, Name = "Таш-Добо", Code = "41705258860100", CoateType = CoateType.Village, ParentId = 85,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1225, Name = "Ынтымак", Code = "41705258860110", CoateType = CoateType.Village, ParentId = 85,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1226, Name = "Чекелик", Code = "41705258860120", CoateType = CoateType.Village, ParentId = 85,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1227, Name = "Шады", Code = "41705258860130", CoateType = CoateType.Village, ParentId = 85,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1228, Name = "Кыргыз-Кыштак", Code = "41705258861010", CoateType = CoateType.Village,
                    ParentId = 86, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1229, Name = "Кожо-Корум", Code = "41705258861020", CoateType = CoateType.Village,
                    ParentId = 86, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1230, Name = "Кайтпас", Code = "41705258861030", CoateType = CoateType.Village, ParentId = 86,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1231, Name = "Бюргендю ОПХ", Code = "41705258861040", CoateType = CoateType.Village,
                    ParentId = 86, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1232, Name = "Бюргендю ПМК", Code = "41705258861050", CoateType = CoateType.Village,
                    ParentId = 86, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1233, Name = "Советский", Code = "41705258864010", CoateType = CoateType.Village,
                    ParentId = 87, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1234, Name = "Чаувай", Code = "41705258867010", CoateType = CoateType.Village, ParentId = 88,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1235, Name = "Ак-Тал", Code = "41704210806010", CoateType = CoateType.Village, ParentId = 228,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1236, Name = "Ак-Чий", Code = "41704210808010", CoateType = CoateType.Village, ParentId = 229,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1237, Name = "Джаны-Тилек", Code = "41704210808020", CoateType = CoateType.Village,
                    ParentId = 229, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1238, Name = "Баетово", Code = "41704210809010", CoateType = CoateType.Village, ParentId = 230,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1239, Name = "Каиынды-Булак", Code = "41704210809020", CoateType = CoateType.Village,
                    ParentId = 230, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1240, Name = "Терек", Code = "41704210811010", CoateType = CoateType.Village, ParentId = 231,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1241, Name = "Орто-Сырт", Code = "41704210811020", CoateType = CoateType.Village,
                    ParentId = 231, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1242, Name = "Кара-Бюрген", Code = "41704210816010", CoateType = CoateType.Village,
                    ParentId = 232, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1243, Name = "Конорчок", Code = "41704210818030", CoateType = CoateType.Village,
                    ParentId = 233, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1244, Name = "Чолок-Кайын", Code = "41704210819010", CoateType = CoateType.Village,
                    ParentId = 234, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1245, Name = "Жерге-Тал", Code = "41704210819020", CoateType = CoateType.Village,
                    ParentId = 234, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1246, Name = "Кош-Дебе", Code = "41704210820010", CoateType = CoateType.Village,
                    ParentId = 235, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1247, Name = "Кадыралы", Code = "41704210822010", CoateType = CoateType.Village,
                    ParentId = 236, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1248, Name = "Джаны-Талап", Code = "41704210825010", CoateType = CoateType.Village,
                    ParentId = 237, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1249, Name = "Кара-Ой", Code = "41704210828010", CoateType = CoateType.Village, ParentId = 238,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1250, Name = "Ак-Кыя", Code = "41704210830010", CoateType = CoateType.Village, ParentId = 239,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1251, Name = "Кек-Джар", Code = "41704210830020", CoateType = CoateType.Village,
                    ParentId = 239, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1252, Name = "Угют", Code = "41704210840010", CoateType = CoateType.Village, ParentId = 240,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1253, Name = "Байгенчек", Code = "41704210840020", CoateType = CoateType.Village,
                    ParentId = 240, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1254, Name = "Ак-Джар", Code = "41704220803010", CoateType = CoateType.Village, ParentId = 241,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1255, Name = "Ак-Моюн", Code = "41704220806010", CoateType = CoateType.Village, ParentId = 242,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1256, Name = "Бирдик", Code = "41704220806020", CoateType = CoateType.Village, ParentId = 242,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1257, Name = "Ак-Муз", Code = "41704220807010", CoateType = CoateType.Village, ParentId = 243,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1258, Name = "Им. Калинина", Code = "41704220808010", CoateType = CoateType.Village,
                    ParentId = 244, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1259, Name = "Терек-Суу    ", Code = "41704220808020", CoateType = CoateType.Village,
                    ParentId = 244, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1260, Name = "Ат-Башы", Code = "41704220812010", CoateType = CoateType.Village, ParentId = 245,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1261, Name = "Ача-Каинды", Code = "41704220813010", CoateType = CoateType.Village,
                    ParentId = 246, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1262, Name = "Баш-Каинды", Code = "41704220817010", CoateType = CoateType.Village,
                    ParentId = 247, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1263, Name = "Большевик", Code = "41704220817020", CoateType = CoateType.Village,
                    ParentId = 247, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1264, Name = "Казыбек", Code = "41704220830010", CoateType = CoateType.Village, ParentId = 248,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1265, Name = "Джаны-Кюч", Code = "41704220830020", CoateType = CoateType.Village,
                    ParentId = 248, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1266, Name = "Кызыл-Туу", Code = "41704220832010", CoateType = CoateType.Village,
                    ParentId = 249, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1267, Name = "Кара-Булун", Code = "41704220832020", CoateType = CoateType.Village,
                    ParentId = 249, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1268, Name = "Кара-Суу", Code = "41704220836010", CoateType = CoateType.Village,
                    ParentId = 250, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1269, Name = "Дыйкан", Code = "41704220836020", CoateType = CoateType.Village, ParentId = 250,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1270, Name = "Талды-Суу", Code = "41704220845010", CoateType = CoateType.Village,
                    ParentId = 251, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1271, Name = "Озгерюш", Code = "41704220845020", CoateType = CoateType.Village, ParentId = 251,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1272, Name = "Первомайское", Code = "41704220845030", CoateType = CoateType.Village,
                    ParentId = 251, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1273, Name = "Баш-Кууганды", Code = "41704230804010", CoateType = CoateType.Village,
                    ParentId = 252, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1274, Name = "Джаны-Арык", Code = "41704230806010", CoateType = CoateType.Village,
                    ParentId = 253, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1275, Name = "Базар-Турук", Code = "41704230806020", CoateType = CoateType.Village,
                    ParentId = 253, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1276, Name = "Кызарт", Code = "41704230806030", CoateType = CoateType.Village, ParentId = 253,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1277, Name = "Кызыл-Эмгек", Code = "41704230806040", CoateType = CoateType.Village,
                    ParentId = 253, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1278, Name = "Джумгал", Code = "41704230809010", CoateType = CoateType.Village, ParentId = 254,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1279, Name = "Лама", Code = "41704230809020", CoateType = CoateType.Village, ParentId = 254,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1280, Name = "Табылгыты", Code = "41704230813010", CoateType = CoateType.Village,
                    ParentId = 255, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1281, Name = "Арал", Code = "41704230813020", CoateType = CoateType.Village, ParentId = 255,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1282, Name = "Кен-Суу", Code = "41704230813030", CoateType = CoateType.Village, ParentId = 255,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1283, Name = "Котур-Суу", Code = "41704230813040", CoateType = CoateType.Village,
                    ParentId = 255, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1284, Name = "Кызыл-Коргон", Code = "41704230813050", CoateType = CoateType.Village,
                    ParentId = 255, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1285, Name = "Сары-Булун", Code = "41704230813060", CoateType = CoateType.Village,
                    ParentId = 255, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1286, Name = "Табылгы", Code = "41704230813070", CoateType = CoateType.Village, ParentId = 255,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1287, Name = "Кек-Ой", Code = "41704230815010", CoateType = CoateType.Village, ParentId = 256,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1288, Name = "Кичи-Арал", Code = "41704230815020", CoateType = CoateType.Village,
                    ParentId = 256, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1289, Name = "Байзак", Code = "41704230817010", CoateType = CoateType.Village, ParentId = 257,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1290, Name = "Куйручук", Code = "41704230825010", CoateType = CoateType.Village,
                    ParentId = 258, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1291, Name = "Чон-Добо", Code = "41704230826010", CoateType = CoateType.Village,
                    ParentId = 259, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1292, Name = "Тюгель-Сай", Code = "41704230834010", CoateType = CoateType.Village,
                    ParentId = 260, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1293, Name = "Эпкин", Code = "41704230834030", CoateType = CoateType.Village, ParentId = 260,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1294, Name = "Таш-Добо", Code = "41704230835010", CoateType = CoateType.Village,
                    ParentId = 261, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1295, Name = "Чаек", Code = "41704230836010", CoateType = CoateType.Village, ParentId = 262,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1296, Name = "Ак-Татыр", Code = "41704230836020", CoateType = CoateType.Village,
                    ParentId = 262, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1297, Name = "Беш-Терек", Code = "41704230836030", CoateType = CoateType.Village,
                    ParentId = 262, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1298, Name = "Кызыл-Жылдыз", Code = "41704230837010", CoateType = CoateType.Village,
                    ParentId = 263, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1299, Name = "Мин-Куш", Code = "41704230840010", CoateType = CoateType.Village, ParentId = 264,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1300, Name = "Кызыл-Сеок", Code = "41704230840020", CoateType = CoateType.Village,
                    ParentId = 264, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1301, Name = "Кара-Суу", Code = "41704235806010", CoateType = CoateType.Village,
                    ParentId = 265, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1302, Name = "Джаны-Джол", Code = "41704235806020", CoateType = CoateType.Village,
                    ParentId = 265, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1303, Name = "Мантыш", Code = "41704235812010", CoateType = CoateType.Village, ParentId = 266,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1304, Name = "Ак-Талаа", Code = "41704235812020", CoateType = CoateType.Village,
                    ParentId = 266, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1305, Name = "Кара-Мойнок", Code = "41704235812030", CoateType = CoateType.Village,
                    ParentId = 266, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1306, Name = "Кызыл-Дебе", Code = "41704235812040", CoateType = CoateType.Village,
                    ParentId = 266, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1307, Name = "Орток", Code = "41704235812050", CoateType = CoateType.Village, ParentId = 266,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1308, Name = "Кочкорка", Code = "41704235816010", CoateType = CoateType.Village,
                    ParentId = 267, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1309, Name = "Большевик", Code = "41704235816020", CoateType = CoateType.Village,
                    ParentId = 267, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1310, Name = "Тендик", Code = "41704235816030", CoateType = CoateType.Village, ParentId = 267,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1311, Name = "Кара-Саз", Code = "41704235819010", CoateType = CoateType.Village,
                    ParentId = 268, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1312, Name = "Кара-Кюнгей", Code = "41704235819020", CoateType = CoateType.Village,
                    ParentId = 268, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1313, Name = "Кум-Дебе", Code = "41704235825010", CoateType = CoateType.Village,
                    ParentId = 269, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1314, Name = "Ак-Джар", Code = "41704235825020", CoateType = CoateType.Village, ParentId = 269,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1315, Name = "Бугучу", Code = "41704235825030", CoateType = CoateType.Village, ParentId = 269,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1316, Name = "Шамшы", Code = "41704235825040", CoateType = CoateType.Village, ParentId = 269,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1317, Name = "Ак-Кыя", Code = "41704235830010", CoateType = CoateType.Village, ParentId = 270,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1318, Name = "Сары-Булак", Code = "41704235830020", CoateType = CoateType.Village,
                    ParentId = 270, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1319, Name = "Кара-Тоо", Code = "41704235832010", CoateType = CoateType.Village,
                    ParentId = 271, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1320, Name = "Арсы", Code = "41704235832020", CoateType = CoateType.Village, ParentId = 271,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1321, Name = "Семиз-Бель", Code = "41704235832030", CoateType = CoateType.Village,
                    ParentId = 271, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1322, Name = "Чекилдек", Code = "41704235832040", CoateType = CoateType.Village,
                    ParentId = 271, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1323, Name = "Ден-Алыш", Code = "41704235835010", CoateType = CoateType.Village,
                    ParentId = 272, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1324, Name = "Комсомол", Code = "41704235835020", CoateType = CoateType.Village,
                    ParentId = 272, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1325, Name = "Кок-Джар", Code = "41704235837010", CoateType = CoateType.Village,
                    ParentId = 273, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1326, Name = "Чолпон", Code = "41704235842010", CoateType = CoateType.Village, ParentId = 274,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1327, Name = "Ара-Кель", Code = "41704235842020", CoateType = CoateType.Village,
                    ParentId = 274, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1328, Name = "Осовиахим", Code = "41704235842030", CoateType = CoateType.Village,
                    ParentId = 274, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1329, Name = "Туз", Code = "41704235842040", CoateType = CoateType.Village, ParentId = 274,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1330, Name = "Эпкин", Code = "41704235842050", CoateType = CoateType.Village, ParentId = 274,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1331, Name = "Телек", Code = "41704235843010", CoateType = CoateType.Village, ParentId = 275,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1332, Name = "Восьмое-Марта", Code = "41704245806010", CoateType = CoateType.Village,
                    ParentId = 276, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1333, Name = "Ак-Кудук", Code = "41704245806020", CoateType = CoateType.Village,
                    ParentId = 276, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1334, Name = "Шоро", Code = "41704245806030", CoateType = CoateType.Village, ParentId = 276,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1335, Name = "Дебелюу", Code = "41704245812010", CoateType = CoateType.Village, ParentId = 277,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1336, Name = "Алыш", Code = "41704245812020", CoateType = CoateType.Village, ParentId = 277,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1337, Name = "Кенеш", Code = "41704245812040", CoateType = CoateType.Village, ParentId = 277,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1338, Name = "Джан-Булак", Code = "41704245815010", CoateType = CoateType.Village,
                    ParentId = 278, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1339, Name = "Джергетал", Code = "41704245818010", CoateType = CoateType.Village,
                    ParentId = 279, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1340, Name = "Джалгыз-Терек", Code = "41704245818020", CoateType = CoateType.Village,
                    ParentId = 279, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1341, Name = "Кызыл-Джылдыз", Code = "41704245818030", CoateType = CoateType.Village,
                    ParentId = 279, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1342, Name = "Казан-Куйган", Code = "41704245825010", CoateType = CoateType.Village,
                    ParentId = 280, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1343, Name = "Кара-Ункюр", Code = "41704245825020", CoateType = CoateType.Village,
                    ParentId = 280, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1344, Name = "Лакол", Code = "41704245829010", CoateType = CoateType.Village, ParentId = 281,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1345, Name = "Джер-Кечкю", Code = "41704245829020", CoateType = CoateType.Village,
                    ParentId = 281, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1346, Name = "Эмгекчил", Code = "41704245832010", CoateType = CoateType.Village,
                    ParentId = 282, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1347, Name = "Им. Куйбышева", Code = "41704245835010", CoateType = CoateType.Village,
                    ParentId = 283, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1348, Name = "Мин-Булак", Code = "41704245835020", CoateType = CoateType.Village,
                    ParentId = 283, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1349, Name = "Орнок", Code = "41704245835030", CoateType = CoateType.Village, ParentId = 283,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1350, Name = "Эчки-Башы", Code = "41704245840010", CoateType = CoateType.Village,
                    ParentId = 284, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1351, Name = "Оттук", Code = "41704245840020", CoateType = CoateType.Village, ParentId = 284,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1352, Name = "Кайынды", Code = "41704245844010", CoateType = CoateType.Village, ParentId = 285,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1353, Name = "Орюк-Там", Code = "41704245844020", CoateType = CoateType.Village,
                    ParentId = 285, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1354, Name = "Таш-Башат", Code = "41704245844030", CoateType = CoateType.Village,
                    ParentId = 285, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1355, Name = "Эки-Нарын", Code = "41704245844040", CoateType = CoateType.Village,
                    ParentId = 285, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1356, Name = "Куланак", Code = "41704245845010", CoateType = CoateType.Village, ParentId = 286,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1357, Name = "Учкун", Code = "41704245845020", CoateType = CoateType.Village, ParentId = 286,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1358, Name = "Орто-Нура", Code = "41704245850010", CoateType = CoateType.Village,
                    ParentId = 287, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1359, Name = "Ак-Булун", Code = "41704245850020", CoateType = CoateType.Village,
                    ParentId = 287, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1360, Name = "Ак-Кыя", Code = "41704245850030", CoateType = CoateType.Village, ParentId = 287,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1361, Name = "Ийри-Суу", Code = "41704245850040", CoateType = CoateType.Village,
                    ParentId = 287, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1362, Name = "Орто-Саз", Code = "41704245850050", CoateType = CoateType.Village,
                    ParentId = 287, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1363, Name = "Орюк-Там (часть)", Code = "41704245850060", CoateType = CoateType.Village,
                    ParentId = 287, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1364, Name = "Чет-Нура", Code = "41704245850070", CoateType = CoateType.Village,
                    ParentId = 287, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1365, Name = "Тош-Булак", Code = "41704245850080", CoateType = CoateType.Village,
                    ParentId = 287, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1366, Name = "Ак-Талаа", Code = "41704245855010", CoateType = CoateType.Village,
                    ParentId = 288, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1367, Name = "Тегерек", Code = "41704245855020", CoateType = CoateType.Village, ParentId = 288,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1368, Name = "Эмгек-Талаа", Code = "41704245855040", CoateType = CoateType.Village,
                    ParentId = 288, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1369, Name = "Жылан-Арык", Code = "41704245860010", CoateType = CoateType.Village,
                    ParentId = 289, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1370, Name = "Достук", Code = "41704245863010", CoateType = CoateType.Village, ParentId = 290,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1371, Name = "Ак-Коргон", Code = "41703204804010", CoateType = CoateType.Village,
                    ParentId = 109, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1372, Name = "Сафедбулан", Code = "41703204804020", CoateType = CoateType.Village,
                    ParentId = 109, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1373, Name = "Падек", Code = "41703204804030", CoateType = CoateType.Village, ParentId = 109,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1374, Name = "Баястан", Code = "41703204804040", CoateType = CoateType.Village, ParentId = 109,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1375, Name = "Ак-Там", Code = "41703204806010", CoateType = CoateType.Village, ParentId = 110,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1376, Name = "Джапа-Салды", Code = "41703204806020", CoateType = CoateType.Village,
                    ParentId = 110, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1377, Name = "Кызыл-Ата", Code = "41703204806030", CoateType = CoateType.Village,
                    ParentId = 110, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1378, Name = "Ала-Бука", Code = "41703204808010", CoateType = CoateType.Village,
                    ParentId = 111, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1379, Name = "Достук", Code = "41703204808020", CoateType = CoateType.Village, ParentId = 111,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1380, Name = "Сапалак", Code = "41703204808030", CoateType = CoateType.Village, ParentId = 111,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1381, Name = "Сары-Талаа", Code = "41703204808040", CoateType = CoateType.Village,
                    ParentId = 111, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1382, Name = "Тенги", Code = "41703204827010", CoateType = CoateType.Village, ParentId = 112,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1383, Name = "Ак-Тайлак", Code = "41703204827020", CoateType = CoateType.Village,
                    ParentId = 112, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1384, Name = "Бирлешкен", Code = "41703204827030", CoateType = CoateType.Village,
                    ParentId = 112, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1385, Name = "Кош-Болот", Code = "41703204827040", CoateType = CoateType.Village,
                    ParentId = 112, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1386, Name = "Сара-Кол", Code = "41703204827050", CoateType = CoateType.Village,
                    ParentId = 112, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1387, Name = "Телеке", Code = "41703204827060", CoateType = CoateType.Village, ParentId = 112,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1388, Name = "Орукту", Code = "41703204847010", CoateType = CoateType.Village, ParentId = 113,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1389, Name = "Кенкол", Code = "41703204847020", CoateType = CoateType.Village, ParentId = 113,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1390, Name = "Орто-Токой", Code = "41703204847030", CoateType = CoateType.Village,
                    ParentId = 113, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1391, Name = "Орукту-Сай", Code = "41703204847040", CoateType = CoateType.Village,
                    ParentId = 113, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1392, Name = "Чолок-Тума", Code = "41703204847050", CoateType = CoateType.Village,
                    ParentId = 113, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1393, Name = "Айры-Там", Code = "41703204850010", CoateType = CoateType.Village,
                    ParentId = 114, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1394, Name = "Ак-Башат", Code = "41703204850020", CoateType = CoateType.Village,
                    ParentId = 114, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1395, Name = "Алма-Бель", Code = "41703204850030", CoateType = CoateType.Village,
                    ParentId = 114, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1396, Name = "Джаны-Шаар", Code = "41703204850060", CoateType = CoateType.Village,
                    ParentId = 114, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1397, Name = "Кара-Ункюр", Code = "41703204850070", CoateType = CoateType.Village,
                    ParentId = 114, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1398, Name = "Ажек", Code = "41703204850090", CoateType = CoateType.Village, ParentId = 114,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1399, Name = "Совет-Сай", Code = "41703204850120", CoateType = CoateType.Village,
                    ParentId = 114, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1400, Name = "Ызар", Code = "41703204855010", CoateType = CoateType.Village, ParentId = 115,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1401, Name = "Баймак", Code = "41703204855020", CoateType = CoateType.Village, ParentId = 115,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1402, Name = "Кашкалак", Code = "41703204855030", CoateType = CoateType.Village,
                    ParentId = 115, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1403, Name = "Келте", Code = "41703204855040", CoateType = CoateType.Village, ParentId = 115,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1404, Name = "Кош-Алмурут", Code = "41703204855050", CoateType = CoateType.Village,
                    ParentId = 115, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1405, Name = "Кош-Терек", Code = "41703204855060", CoateType = CoateType.Village,
                    ParentId = 115, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1406, Name = "Кажар", Code = "41703204855070", CoateType = CoateType.Village, ParentId = 115,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1407, Name = "Булак-Башы", Code = "41703204856010", CoateType = CoateType.Village,
                    ParentId = 116, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1408, Name = "Джалгыз-Орюк", Code = "41703204856020", CoateType = CoateType.Village,
                    ParentId = 116, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1409, Name = "Кек-Таш", Code = "41703204856030", CoateType = CoateType.Village, ParentId = 116,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1410, Name = "Кулпек-Сай", Code = "41703204856040", CoateType = CoateType.Village,
                    ParentId = 116, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1411, Name = "Орто-Суу", Code = "41703204856050", CoateType = CoateType.Village,
                    ParentId = 116, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1412, Name = "Чон-Сай", Code = "41703204856060", CoateType = CoateType.Village, ParentId = 116,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1413, Name = "Джаны-Акман", Code = "41703207808010", CoateType = CoateType.Village,
                    ParentId = 117, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1414, Name = "Джараке", Code = "41703207808020", CoateType = CoateType.Village, ParentId = 117,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1415, Name = "Кайырма", Code = "41703207808030", CoateType = CoateType.Village, ParentId = 117,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1416, Name = "Колот", Code = "41703207808040", CoateType = CoateType.Village, ParentId = 117,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1417, Name = "Коргон-Джар", Code = "41703207808050", CoateType = CoateType.Village,
                    ParentId = 117, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1418, Name = "Кош-Коргон", Code = "41703207808060", CoateType = CoateType.Village,
                    ParentId = 117, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1419, Name = "Таш-Булак", Code = "41703207808070", CoateType = CoateType.Village,
                    ParentId = 117, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1420, Name = "Базар-Коргон", Code = "41703207812010", CoateType = CoateType.Village,
                    ParentId = 118, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1421, Name = "Беш-Бадам", Code = "41703207812020", CoateType = CoateType.Village,
                    ParentId = 118, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1422, Name = "Джети-Кошкон", Code = "41703207812030", CoateType = CoateType.Village,
                    ParentId = 118, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1423, Name = "Кек-Алма", Code = "41703207812040", CoateType = CoateType.Village,
                    ParentId = 118, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1424, Name = "Бешик-Джон", Code = "41703207815010", CoateType = CoateType.Village,
                    ParentId = 119, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1425, Name = "Джон", Code = "41703207815020", CoateType = CoateType.Village, ParentId = 119,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1426, Name = "Баймундуз", Code = "41703207815030", CoateType = CoateType.Village,
                    ParentId = 119, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1427, Name = "Карача", Code = "41703207815040", CoateType = CoateType.Village, ParentId = 119,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1428, Name = "Кек-Алма", Code = "41703207815050", CoateType = CoateType.Village,
                    ParentId = 119, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1429, Name = "Арсланбоб", Code = "41703207826010", CoateType = CoateType.Village,
                    ParentId = 120, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1430, Name = "Ак-Терек", Code = "41703207826020", CoateType = CoateType.Village,
                    ParentId = 120, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1431, Name = "Бель-Терек", Code = "41703207826030", CoateType = CoateType.Village,
                    ParentId = 120, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1432, Name = "Гава", Code = "41703207826040", CoateType = CoateType.Village, ParentId = 120,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1433, Name = "Гумхана", Code = "41703207826050", CoateType = CoateType.Village, ParentId = 120,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1434, Name = "Дашман", Code = "41703207826060", CoateType = CoateType.Village, ParentId = 120,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1435, Name = "Джай-Терек", Code = "41703207826070", CoateType = CoateType.Village,
                    ParentId = 120, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1436, Name = "Джарадар", Code = "41703207826080", CoateType = CoateType.Village,
                    ParentId = 120, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1437, Name = "Кызыл-Ункюр", Code = "41703207832010", CoateType = CoateType.Village,
                    ParentId = 121, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1438, Name = "Ак-Булак", Code = "41703207832020", CoateType = CoateType.Village,
                    ParentId = 121, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1439, Name = "Джаз-Кечуу", Code = "41703207832030", CoateType = CoateType.Village,
                    ParentId = 121, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1440, Name = "Катар-Джангак", Code = "41703207832040", CoateType = CoateType.Village,
                    ParentId = 121, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1441, Name = "Косо-Терек", Code = "41703207832050", CoateType = CoateType.Village,
                    ParentId = 121, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1442, Name = "Оогон-Талаа", Code = "41703207842010", CoateType = CoateType.Village,
                    ParentId = 122, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1443, Name = "Бувакол", Code = "41703207842020", CoateType = CoateType.Village, ParentId = 122,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1444, Name = "Кайнар", Code = "41703207842030", CoateType = CoateType.Village, ParentId = 122,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1445, Name = "Кара-Ой", Code = "41703207842040", CoateType = CoateType.Village, ParentId = 122,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1446, Name = "Кызыл-Суу", Code = "41703207842050", CoateType = CoateType.Village,
                    ParentId = 122, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1447, Name = "Коктонду", Code = "41703207842060", CoateType = CoateType.Village,
                    ParentId = 122, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1448, Name = "Чарбак", Code = "41703207842070", CoateType = CoateType.Village, ParentId = 122,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1449, Name = "Им. Чкалова", Code = "41703207842080", CoateType = CoateType.Village,
                    ParentId = 122, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1450, Name = "Сайдыкум", Code = "41703207856010", CoateType = CoateType.Village,
                    ParentId = 123, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1451, Name = "Аркалык", Code = "41703207856020", CoateType = CoateType.Village, ParentId = 123,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1452, Name = "Джаны-Абад", Code = "41703207856030", CoateType = CoateType.Village,
                    ParentId = 123, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1453, Name = "Джаш-Ленин", Code = "41703207856040", CoateType = CoateType.Village,
                    ParentId = 123, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1454, Name = "Деш", Code = "41703207856050", CoateType = CoateType.Village, ParentId = 123,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1455, Name = "Дукур", Code = "41703207856060", CoateType = CoateType.Village, ParentId = 123,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1456, Name = "Киргиз-Гава", Code = "41703207856080", CoateType = CoateType.Village,
                    ParentId = 123, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1457, Name = "Кызыл-Ай", Code = "41703207856090", CoateType = CoateType.Village,
                    ParentId = 123, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1458, Name = "Тойчубек-Чек", Code = "41703207856100", CoateType = CoateType.Village,
                    ParentId = 123, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1459, Name = "Турпак-Коргон", Code = "41703207856110", CoateType = CoateType.Village,
                    ParentId = 123, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1460, Name = "Хаджир-Абад", Code = "41703207856130", CoateType = CoateType.Village,
                    ParentId = 123, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1461, Name = "Чек", Code = "41703207856140", CoateType = CoateType.Village, ParentId = 123,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1462, Name = "Чон-Курулуш", Code = "41703207856150", CoateType = CoateType.Village,
                    ParentId = 123, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1463, Name = "Каба        ", Code = "41703207857010", CoateType = CoateType.Village,
                    ParentId = 124, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1464, Name = "Сары-Жайык", Code = "41703207857020", CoateType = CoateType.Village,
                    ParentId = 124, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1465, Name = "Катар-Жангак", Code = "41703207857030", CoateType = CoateType.Village,
                    ParentId = 124, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1466, Name = "Ак-Тыт", Code = "41703207857040", CoateType = CoateType.Village, ParentId = 124,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1467, Name = "Уч-Булак", Code = "41703207857050", CoateType = CoateType.Village,
                    ParentId = 124, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1468, Name = "Ак-Терек", Code = "41703207857060", CoateType = CoateType.Village,
                    ParentId = 124, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1469, Name = "Кек-Алма", Code = "41703207857070", CoateType = CoateType.Village,
                    ParentId = 124, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1470, Name = "Кыргоо                                             ", Code = "41703207857080",
                    CoateType = CoateType.Village, ParentId = 124, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1471, Name = "Советское", Code = "41703207859010", CoateType = CoateType.Village,
                    ParentId = 125, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1472, Name = "Аук", Code = "41703207859020", CoateType = CoateType.Village, ParentId = 125,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1473, Name = "Кара-Джыгач", Code = "41703207859030", CoateType = CoateType.Village,
                    ParentId = 125, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1474, Name = "Кызыл-Октябрь", Code = "41703207859040", CoateType = CoateType.Village,
                    ParentId = 125, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1475, Name = "Могол-Коргон", Code = "41703207859050", CoateType = CoateType.Village,
                    ParentId = 125, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1476, Name = "Первое  Мая", Code = "41703207859060", CoateType = CoateType.Village,
                    ParentId = 125, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1477, Name = "Сейит-Казы", Code = "41703207859070", CoateType = CoateType.Village,
                    ParentId = 125, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1478, Name = "Шыдыр", Code = "41703207859080", CoateType = CoateType.Village, ParentId = 125,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1479, Name = "Ак-Джол", Code = "41703211804010", CoateType = CoateType.Village, ParentId = 98,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1480, Name = "Джолборсту", Code = "41703211804020", CoateType = CoateType.Village,
                    ParentId = 98, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1481, Name = "Кара-Тыт", Code = "41703211804030", CoateType = CoateType.Village, ParentId = 98,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1482, Name = "Кечуу", Code = "41703211804040", CoateType = CoateType.Village, ParentId = 98,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1483, Name = "Райкомол", Code = "41703211804050", CoateType = CoateType.Village, ParentId = 98,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1484, Name = "Тегене", Code = "41703211804060", CoateType = CoateType.Village, ParentId = 98,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1485, Name = "Кызыл-Бейит", Code = "41703211804070", CoateType = CoateType.Village,
                    ParentId = 98, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1486, Name = "Кюрп", Code = "41703211804080", CoateType = CoateType.Village, ParentId = 98,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1487, Name = "Разан-Сай", Code = "41703211804090", CoateType = CoateType.Village,
                    ParentId = 98, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1488, Name = "Авлетим", Code = "41703211808010", CoateType = CoateType.Village, ParentId = 99,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1489, Name = "Байкашка-Терек", Code = "41703211808020", CoateType = CoateType.Village,
                    ParentId = 99, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1490, Name = "Дерес-Сай", Code = "41703211808030", CoateType = CoateType.Village,
                    ParentId = 99, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1491, Name = "Джангактуу-Булак", Code = "41703211808040", CoateType = CoateType.Village,
                    ParentId = 99, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1492, Name = "Ит-Агар", Code = "41703211808050", CoateType = CoateType.Village, ParentId = 99,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1493, Name = "Коргон", Code = "41703211808060", CoateType = CoateType.Village, ParentId = 99,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1494, Name = "Мукур", Code = "41703211808070", CoateType = CoateType.Village, ParentId = 99,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1495, Name = "Тегермен-Сай", Code = "41703211808080", CoateType = CoateType.Village,
                    ParentId = 99, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1496, Name = "Товар-Сай", Code = "41703211808090", CoateType = CoateType.Village,
                    ParentId = 99, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1497, Name = "Джаны-Джол", Code = "41703211813010", CoateType = CoateType.Village,
                    ParentId = 100, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1498, Name = "Кой-Таш", Code = "41703211813020", CoateType = CoateType.Village, ParentId = 100,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1499, Name = "Таштак", Code = "41703211813030", CoateType = CoateType.Village, ParentId = 100,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1500, Name = "Терс", Code = "41703211813040", CoateType = CoateType.Village, ParentId = 100,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1501, Name = "Ак-Суу", Code = "41703211824010", CoateType = CoateType.Village, ParentId = 101,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1502, Name = "Ак-Сай", Code = "41703211824020", CoateType = CoateType.Village, ParentId = 101,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1503, Name = "Коргон-Дебе", Code = "41703211824030", CoateType = CoateType.Village,
                    ParentId = 101, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1504, Name = "Кара-Джыгач", Code = "41703211832010", CoateType = CoateType.Village,
                    ParentId = 102, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1505, Name = "Дардак-Дебе", Code = "41703211832020", CoateType = CoateType.Village,
                    ParentId = 102, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1506, Name = "Кара-Ой", Code = "41703211832030", CoateType = CoateType.Village, ParentId = 102,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1507, Name = "Сыны", Code = "41703211832070", CoateType = CoateType.Village, ParentId = 102,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1508, Name = "Торкамыш", Code = "41703211832080", CoateType = CoateType.Village,
                    ParentId = 102, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1509, Name = "Чарба", Code = "41703211832090", CoateType = CoateType.Village, ParentId = 102,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1510, Name = "Кашка-Суу", Code = "41703211836010", CoateType = CoateType.Village,
                    ParentId = 103, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1511, Name = "Джаны-Айыл", Code = "41703211836020", CoateType = CoateType.Village,
                    ParentId = 103, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1512, Name = "Кара-Дебе", Code = "41703211836030", CoateType = CoateType.Village,
                    ParentId = 103, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1513, Name = "Согот", Code = "41703211836040", CoateType = CoateType.Village, ParentId = 103,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1514, Name = "Атана", Code = "41703211842010", CoateType = CoateType.Village, ParentId = 104,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1515, Name = "Мундуз", Code = "41703211842020", CoateType = CoateType.Village, ParentId = 104,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1516, Name = "Сары-Кашка", Code = "41703211842030", CoateType = CoateType.Village,
                    ParentId = 104, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1517, Name = "Семет", Code = "41703211842040", CoateType = CoateType.Village, ParentId = 104,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1518, Name = "Торук", Code = "41703211842050", CoateType = CoateType.Village, ParentId = 104,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1519, Name = "Улук", Code = "41703211842060", CoateType = CoateType.Village, ParentId = 104,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1520, Name = "Чие", Code = "41703211842070", CoateType = CoateType.Village, ParentId = 104,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1521, Name = "Таш-Жар", Code = "41703211842080", CoateType = CoateType.Village, ParentId = 104,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1522, Name = "Жангак", Code = "41703211842090", CoateType = CoateType.Village, ParentId = 104,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1523, Name = "Кызыл-Туу", Code = "41703211849010", CoateType = CoateType.Village,
                    ParentId = 105, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1524, Name = "Аркит", Code = "41703211849020", CoateType = CoateType.Village, ParentId = 105,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1525, Name = "Джылгын", Code = "41703211849030", CoateType = CoateType.Village, ParentId = 105,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1526, Name = "Джол-Сай", Code = "41703211849040", CoateType = CoateType.Village,
                    ParentId = 105, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1527, Name = "Топ-Джангак", Code = "41703211857010", CoateType = CoateType.Village,
                    ParentId = 106, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1528, Name = "Джузумжан", Code = "41703211857020", CoateType = CoateType.Village,
                    ParentId = 106, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1529, Name = "Кара-Суу", Code = "41703211857030", CoateType = CoateType.Village,
                    ParentId = 106, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1530, Name = "Кезарт", Code = "41703211857040", CoateType = CoateType.Village, ParentId = 106,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1531, Name = "Кызыл-Кель", Code = "41703211857050", CoateType = CoateType.Village,
                    ParentId = 106, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1532, Name = "Сай-Булун", Code = "41703211857060", CoateType = CoateType.Village,
                    ParentId = 106, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1533, Name = "Турдюк", Code = "41703211857070", CoateType = CoateType.Village, ParentId = 106,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1534, Name = "Чалдыбар", Code = "41703211857080", CoateType = CoateType.Village,
                    ParentId = 106, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1535, Name = "Чат", Code = "41703211857090", CoateType = CoateType.Village, ParentId = 106,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1536, Name = "Джерге-Тал", Code = "41703211860010", CoateType = CoateType.Village,
                    ParentId = 107, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1537, Name = "Боспиек", Code = "41703211860020", CoateType = CoateType.Village, ParentId = 107,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1538, Name = "Кызыл-Капчыгай", Code = "41703211860030", CoateType = CoateType.Village,
                    ParentId = 107, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1539, Name = "Кызыл-Джар", Code = "41703211863010", CoateType = CoateType.Village,
                    ParentId = 108, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1540, Name = "Джыл-Кол", Code = "41703211863020", CoateType = CoateType.Village,
                    ParentId = 108, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1541, Name = "Кум", Code = "41703211863030", CoateType = CoateType.Village, ParentId = 108,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1542, Name = "Нарын", Code = "41703211863040", CoateType = CoateType.Village, ParentId = 108,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1543, Name = "Арал", Code = "41703215804010", CoateType = CoateType.Village, ParentId = 126,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1544, Name = "Интернационал", Code = "41703215804020", CoateType = CoateType.Village,
                    ParentId = 126, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1545, Name = "Рассвет", Code = "41703215804030", CoateType = CoateType.Village, ParentId = 126,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1546, Name = "Чертак-Таш", Code = "41703215804040", CoateType = CoateType.Village,
                    ParentId = 126, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1547, Name = "Черемушки", Code = "41703215804050", CoateType = CoateType.Village,
                    ParentId = 126, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1548, Name = "Бюргендю", Code = "41703215819010", CoateType = CoateType.Village,
                    ParentId = 127, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1549, Name = "Джаны-Арык", Code = "41703215819020", CoateType = CoateType.Village,
                    ParentId = 127, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1550, Name = "Джениш", Code = "41703215819030", CoateType = CoateType.Village, ParentId = 127,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1551, Name = "Кичи-Бюргендю", Code = "41703215819040", CoateType = CoateType.Village,
                    ParentId = 127, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1552, Name = "Кокандык", Code = "41703215819050", CoateType = CoateType.Village,
                    ParentId = 127, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1553, Name = "Курама", Code = "41703215819060", CoateType = CoateType.Village, ParentId = 127,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1554, Name = "Кызыл-Кыя", Code = "41703215819070", CoateType = CoateType.Village,
                    ParentId = 127, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1555, Name = "Ноошкен", Code = "41703215819080", CoateType = CoateType.Village, ParentId = 127,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1556, Name = "Ууру-Джар", Code = "41703215819090", CoateType = CoateType.Village,
                    ParentId = 127, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1557, Name = "Шамалды-Сай", Code = "41703215821010", CoateType = CoateType.Village,
                    ParentId = 128, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1558, Name = "Достук", Code = "41703215821020", CoateType = CoateType.Village, ParentId = 128,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1559, Name = "Кудук", Code = "41703215821030", CoateType = CoateType.Village, ParentId = 128,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1560, Name = "Кызыл-Туу", Code = "41703215821040", CoateType = CoateType.Village,
                    ParentId = 128, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1561, Name = "Сары-Камыш", Code = "41703215821050", CoateType = CoateType.Village,
                    ParentId = 128, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1562, Name = "Шынг-Сай", Code = "41703215821060", CoateType = CoateType.Village,
                    ParentId = 128, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1563, Name = "Массы", Code = "41703215836010", CoateType = CoateType.Village, ParentId = 129,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1564, Name = "Апыртан", Code = "41703215836020", CoateType = CoateType.Village, ParentId = 129,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1565, Name = "Беш-Джыгач", Code = "41703215836030", CoateType = CoateType.Village,
                    ParentId = 129, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1566, Name = "Бегет", Code = "41703215836040", CoateType = CoateType.Village, ParentId = 129,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1567, Name = "Кызыл-Туу   ", Code = "41703215836050", CoateType = CoateType.Village,
                    ParentId = 129, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1568, Name = "Момбеково", Code = "41703215840010", CoateType = CoateType.Village,
                    ParentId = 130, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1569, Name = "Бостон", Code = "41703215840020", CoateType = CoateType.Village, ParentId = 130,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1570, Name = "Джазгак", Code = "41703215840030", CoateType = CoateType.Village, ParentId = 130,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1571, Name = "Джаны-Кыштак", Code = "41703215840040", CoateType = CoateType.Village,
                    ParentId = 130, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1572, Name = "Кок-Таш", Code = "41703215840050", CoateType = CoateType.Village, ParentId = 130,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1573, Name = "Кочкор-Ата", Code = "41703215840060", CoateType = CoateType.Village,
                    ParentId = 130, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1574, Name = "Курулуш", Code = "41703215840070", CoateType = CoateType.Village, ParentId = 130,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1575, Name = "Чек", Code = "41703215840080", CoateType = CoateType.Village, ParentId = 130,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1576, Name = "Курулуш", Code = "41703215846010", CoateType = CoateType.Village, ParentId = 131,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1577, Name = "Кара-Булак", Code = "41703215846020", CoateType = CoateType.Village,
                    ParentId = 131, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1578, Name = "Им. Кирова", Code = "41703215846030", CoateType = CoateType.Village,
                    ParentId = 131, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1579, Name = "Коминтерн", Code = "41703215846040", CoateType = CoateType.Village,
                    ParentId = 131, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1580, Name = "Кызыл-Джылдыз", Code = "41703215846050", CoateType = CoateType.Village,
                    ParentId = 131, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1581, Name = "Параканда", Code = "41703215846060", CoateType = CoateType.Village,
                    ParentId = 131, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1582, Name = "Рахманджан      ", Code = "41703215846070", CoateType = CoateType.Village,
                    ParentId = 131, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1583, Name = "Сакалды", Code = "41703215851010", CoateType = CoateType.Village, ParentId = 132,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1584, Name = "Аримджан", Code = "41703215851020", CoateType = CoateType.Village,
                    ParentId = 132, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1585, Name = "Бобуй", Code = "41703215851030", CoateType = CoateType.Village, ParentId = 132,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1586, Name = "Кагазды", Code = "41703215851040", CoateType = CoateType.Village, ParentId = 132,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1587, Name = "Кызыл-Кыргызстан", Code = "41703215851050", CoateType = CoateType.Village,
                    ParentId = 132, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1588, Name = "Чек", Code = "41703215851060", CoateType = CoateType.Village, ParentId = 132,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1589, Name = "Чон-Багыш", Code = "41703215851070", CoateType = CoateType.Village,
                    ParentId = 132, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1590, Name = "Алма", Code = "41703215876010", CoateType = CoateType.Village, ParentId = 133,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1591, Name = "Бирдик", Code = "41703215876020", CoateType = CoateType.Village, ParentId = 133,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1592, Name = "Джаны-Арык", Code = "41703215876030", CoateType = CoateType.Village,
                    ParentId = 133, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1593, Name = "Джон-Арык", Code = "41703215876040", CoateType = CoateType.Village,
                    ParentId = 133, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1594, Name = "Кек-Айдар", Code = "41703215876050", CoateType = CoateType.Village,
                    ParentId = 133, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1595, Name = "Тоскоол", Code = "41703215876060", CoateType = CoateType.Village, ParentId = 133,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1596, Name = "Эски-Массы", Code = "41703215876070", CoateType = CoateType.Village,
                    ParentId = 133, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1597, Name = "Жоон-Кунгой", Code = "41703220805030", CoateType = CoateType.Village,
                    ParentId = 134, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1598, Name = "Калмак-Кырчын", Code = "41703220805040", CoateType = CoateType.Village,
                    ParentId = 134, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1599, Name = "Канджыга", Code = "41703220805050", CoateType = CoateType.Village,
                    ParentId = 134, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1600, Name = "Кара-Чолок", Code = "41703220805060", CoateType = CoateType.Village,
                    ParentId = 134, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1601, Name = "Сары-Булак", Code = "41703220805070", CoateType = CoateType.Village,
                    ParentId = 134, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1602, Name = "Саты", Code = "41703220805080", CoateType = CoateType.Village, ParentId = 134,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1603, Name = "Таран-Базар", Code = "41703220805090", CoateType = CoateType.Village,
                    ParentId = 134, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1604, Name = "Урумбаш", Code = "41703220805100", CoateType = CoateType.Village, ParentId = 134,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1605, Name = "Комсомол", Code = "41703220812010", CoateType = CoateType.Village,
                    ParentId = 135, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1606, Name = "Ачы", Code = "41703220812020", CoateType = CoateType.Village, ParentId = 135,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1607, Name = "Боз-Чычкан", Code = "41703220812030", CoateType = CoateType.Village,
                    ParentId = 135, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1608, Name = "Беш-Мойнок", Code = "41703220812040", CoateType = CoateType.Village,
                    ParentId = 135, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1609, Name = "Джаны-Айыл", Code = "41703220812050", CoateType = CoateType.Village,
                    ParentId = 135, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1610, Name = "Джар-Кыштак", Code = "41703220812060", CoateType = CoateType.Village,
                    ParentId = 135, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1611, Name = "Дебей", Code = "41703220812070", CoateType = CoateType.Village, ParentId = 135,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1612, Name = "Канды", Code = "41703220812080", CoateType = CoateType.Village, ParentId = 135,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1613, Name = "Мин-Орюк", Code = "41703220812090", CoateType = CoateType.Village,
                    ParentId = 135, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1614, Name = "Маркай", Code = "41703220812100", CoateType = CoateType.Village, ParentId = 135,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1615, Name = "Пригородный", Code = "41703220812110", CoateType = CoateType.Village,
                    ParentId = 135, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1616, Name = "Сай", Code = "41703220812120", CoateType = CoateType.Village, ParentId = 135,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1617, Name = "Теолес", Code = "41703220812130", CoateType = CoateType.Village, ParentId = 135,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1618, Name = "Таштак", Code = "41703220812140", CoateType = CoateType.Village, ParentId = 135,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1619, Name = "Тюрк-Маала", Code = "41703220812150", CoateType = CoateType.Village,
                    ParentId = 135, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1620, Name = "Ульгю", Code = "41703220812160", CoateType = CoateType.Village, ParentId = 135,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1621, Name = "Ченгет-Сай", Code = "41703220812170", CoateType = CoateType.Village,
                    ParentId = 135, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1622, Name = "Чеке-Дебе", Code = "41703220812180", CoateType = CoateType.Village,
                    ParentId = 135, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1623, Name = "Чокмор", Code = "41703220812190", CoateType = CoateType.Village, ParentId = 135,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1624, Name = "Кара-Алма", Code = "41703220825010", CoateType = CoateType.Village,
                    ParentId = 136, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1625, Name = "Орток", Code = "41703220825020", CoateType = CoateType.Village, ParentId = 136,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1626, Name = "Туура-Джангак", Code = "41703220825030", CoateType = CoateType.Village,
                    ParentId = 136, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1627, Name = "Урумбаш", Code = "41703220825040", CoateType = CoateType.Village, ParentId = 136,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1628, Name = "Арал", Code = "41703220828010", CoateType = CoateType.Village, ParentId = 137,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1629, Name = "Теш", Code = "41703220828020", CoateType = CoateType.Village, ParentId = 137,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1630, Name = "Чангыр-Таш", Code = "41703220828030", CoateType = CoateType.Village,
                    ParentId = 137, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1631, Name = "Михайловка", Code = "41703220834010", CoateType = CoateType.Village,
                    ParentId = 138, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1632, Name = "Комсомол", Code = "41703220834020", CoateType = CoateType.Village,
                    ParentId = 138, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1633, Name = "Подгорное", Code = "41703220834030", CoateType = CoateType.Village,
                    ParentId = 138, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1634, Name = "Уч-Малай", Code = "41703220834040", CoateType = CoateType.Village,
                    ParentId = 138, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1635, Name = "Карамарт", Code = "41703220838010", CoateType = CoateType.Village,
                    ParentId = 139, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1636, Name = "Ак-Булак", Code = "41703220838020", CoateType = CoateType.Village,
                    ParentId = 139, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1637, Name = "Ак-Тоок", Code = "41703220838030", CoateType = CoateType.Village, ParentId = 139,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1638, Name = "Джаны-Арык", Code = "41703220838040", CoateType = CoateType.Village,
                    ParentId = 139, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1639, Name = "Джылан-Темир", Code = "41703220838050", CoateType = CoateType.Village,
                    ParentId = 139, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1640, Name = "Каду", Code = "41703220838060", CoateType = CoateType.Village, ParentId = 139,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1641, Name = "Кара-Булак", Code = "41703220838070", CoateType = CoateType.Village,
                    ParentId = 139, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1642, Name = "Катранкы", Code = "41703220838080", CoateType = CoateType.Village,
                    ParentId = 139, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1643, Name = "Кашка-Терек", Code = "41703220838090", CoateType = CoateType.Village,
                    ParentId = 139, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1644, Name = "Кыз-Кель", Code = "41703220838100", CoateType = CoateType.Village,
                    ParentId = 139, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1645, Name = "Кызыл-Кия", Code = "41703220838110", CoateType = CoateType.Village,
                    ParentId = 139, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1646, Name = "Сары-Булак", Code = "41703220838120", CoateType = CoateType.Village,
                    ParentId = 139, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1647, Name = "Бостон", Code = "41703220842010", CoateType = CoateType.Village, ParentId = 140,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1648, Name = "Ак-Булак", Code = "41703220842020", CoateType = CoateType.Village,
                    ParentId = 140, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1649, Name = "Ак-Терек", Code = "41703220842030", CoateType = CoateType.Village,
                    ParentId = 140, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1650, Name = "Акчалуу", Code = "41703220842040", CoateType = CoateType.Village, ParentId = 140,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1651, Name = "Алмалуу-Булак", Code = "41703220842050", CoateType = CoateType.Village,
                    ParentId = 140, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1652, Name = "Кара-Инген", Code = "41703220842060", CoateType = CoateType.Village,
                    ParentId = 140, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1653, Name = "Кара-Кель", Code = "41703220842070", CoateType = CoateType.Village,
                    ParentId = 140, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1654, Name = "Кызыл-Сенир", Code = "41703220842080", CoateType = CoateType.Village,
                    ParentId = 140, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1655, Name = "Орто-Азия", Code = "41703220842090", CoateType = CoateType.Village,
                    ParentId = 140, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1656, Name = "Соку-Таш", Code = "41703220842100", CoateType = CoateType.Village,
                    ParentId = 140, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1657, Name = "Ак-Баш", Code = "41703220842110", CoateType = CoateType.Village, ParentId = 140,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1658, Name = "Шатрак", Code = "41703220842120", CoateType = CoateType.Village, ParentId = 140,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1659, Name = "Жаны-Ачы", Code = "41703220842130", CoateType = CoateType.Village,
                    ParentId = 140, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1660, Name = "Кашка-Суу", Code = "41703220842140", CoateType = CoateType.Village,
                    ParentId = 140, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1661, Name = "Жашасын-2", Code = "41703220842150", CoateType = CoateType.Village,
                    ParentId = 140, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1662, Name = "Алчалуу", Code = "41703220842160", CoateType = CoateType.Village, ParentId = 140,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1663, Name = "Кызыл-Алма", Code = "41703220842170", CoateType = CoateType.Village,
                    ParentId = 140, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1664, Name = "Талаа-Булак", Code = "41703220842180", CoateType = CoateType.Village,
                    ParentId = 140, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1665, Name = "Таштак", Code = "41703220842190", CoateType = CoateType.Village, ParentId = 140,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1666, Name = "Мундуз", Code = "41703220842200", CoateType = CoateType.Village, ParentId = 140,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1667, Name = "Ленинское", Code = "41703220846010", CoateType = CoateType.Village,
                    ParentId = 141, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1668, Name = "Гавриловка", Code = "41703220846020", CoateType = CoateType.Village,
                    ParentId = 141, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1669, Name = "Им. Фрунзе", Code = "41703220846030", CoateType = CoateType.Village,
                    ParentId = 141, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1670, Name = "Октябрьское", Code = "41703220851010", CoateType = CoateType.Village,
                    ParentId = 142, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1671, Name = "Багыш", Code = "41703220851020", CoateType = CoateType.Village, ParentId = 142,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1672, Name = "Беш-Бала", Code = "41703220851030", CoateType = CoateType.Village,
                    ParentId = 142, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1673, Name = "Кедей-Арык", Code = "41703220851040", CoateType = CoateType.Village,
                    ParentId = 142, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1674, Name = "Кызыл-Туу", Code = "41703220851050", CoateType = CoateType.Village,
                    ParentId = 142, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1675, Name = "Сары-Булак", Code = "41703220851060", CoateType = CoateType.Village,
                    ParentId = 142, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1676, Name = "Сафаровка", Code = "41703220851070", CoateType = CoateType.Village,
                    ParentId = 142, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1677, Name = "Бек-Абад", Code = "41703220854010", CoateType = CoateType.Village,
                    ParentId = 143, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1678, Name = "Балта-Казы", Code = "41703220854020", CoateType = CoateType.Village,
                    ParentId = 143, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1679, Name = "Бекей", Code = "41703220854030", CoateType = CoateType.Village, ParentId = 143,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1680, Name = "Бостон", Code = "41703220854040", CoateType = CoateType.Village, ParentId = 143,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1681, Name = "Джаны-Джер", Code = "41703220854050", CoateType = CoateType.Village,
                    ParentId = 143, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1682, Name = "Джийде", Code = "41703220854060", CoateType = CoateType.Village, ParentId = 143,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1683, Name = "Кайнар", Code = "41703220854070", CoateType = CoateType.Village, ParentId = 143,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1684, Name = "Кара-Джыгач", Code = "41703220854080", CoateType = CoateType.Village,
                    ParentId = 143, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1685, Name = "Кашкар-Маала", Code = "41703220854090", CoateType = CoateType.Village,
                    ParentId = 143, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1686, Name = "Кызыл-Багыш", Code = "41703220854100", CoateType = CoateType.Village,
                    ParentId = 143, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1687, Name = "Кыргыз-Абад", Code = "41703220854110", CoateType = CoateType.Village,
                    ParentId = 143, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1688, Name = "Мундуз", Code = "41703220854120", CoateType = CoateType.Village, ParentId = 143,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1689, Name = "Найман", Code = "41703220854130", CoateType = CoateType.Village, ParentId = 143,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1690, Name = "Таш-Булак", Code = "41703220854140", CoateType = CoateType.Village,
                    ParentId = 143, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1691, Name = "Тюрк-Абад", Code = "41703220854150", CoateType = CoateType.Village,
                    ParentId = 143, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1692, Name = "Узбек-Абад", Code = "41703220854160", CoateType = CoateType.Village,
                    ParentId = 143, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1693, Name = "Чек", Code = "41703220854170", CoateType = CoateType.Village, ParentId = 143,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1694, Name = "Ширин", Code = "41703220854180", CoateType = CoateType.Village, ParentId = 143,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1695, Name = "Сузак", Code = "41703220856010", CoateType = CoateType.Village, ParentId = 144,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1696, Name = "Арал", Code = "41703220856020", CoateType = CoateType.Village, ParentId = 144,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1697, Name = "Благовещенка  ", Code = "41703220856030", CoateType = CoateType.Village,
                    ParentId = 144, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1698, Name = "Джаны-Дыйкан", Code = "41703220856040", CoateType = CoateType.Village,
                    ParentId = 144, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1699, Name = "Достук", Code = "41703220856050", CoateType = CoateType.Village, ParentId = 144,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1700, Name = "Камыш-Башы", Code = "41703220856060", CoateType = CoateType.Village,
                    ParentId = 144, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1701, Name = "Кыр-Джол", Code = "41703220856070", CoateType = CoateType.Village,
                    ParentId = 144, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1702, Name = "Садда", Code = "41703220856080", CoateType = CoateType.Village, ParentId = 144,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1703, Name = "Таш-Булак", Code = "41703220863010", CoateType = CoateType.Village,
                    ParentId = 145, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1704, Name = "Арал", Code = "41703220863020", CoateType = CoateType.Village, ParentId = 145,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1705, Name = "Гюльстан", Code = "41703220863030", CoateType = CoateType.Village,
                    ParentId = 145, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1706, Name = "Димитровка", Code = "41703220863040", CoateType = CoateType.Village,
                    ParentId = 145, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1707, Name = "Доскана", Code = "41703220863050", CoateType = CoateType.Village, ParentId = 145,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1708, Name = "Эшме", Code = "41703220863060", CoateType = CoateType.Village, ParentId = 145,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1709, Name = "Кюмюш-Азиз", Code = "41703220874010", CoateType = CoateType.Village,
                    ParentId = 146, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1710, Name = "Арал-Сай", Code = "41703220874020", CoateType = CoateType.Village,
                    ParentId = 146, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1711, Name = "Джар-Кыштак", Code = "41703220874030", CoateType = CoateType.Village,
                    ParentId = 146, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1712, Name = "Демер", Code = "41703220874040", CoateType = CoateType.Village, ParentId = 146,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1713, Name = "Кайнар", Code = "41703220874050", CoateType = CoateType.Village, ParentId = 146,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1714, Name = "Кургак-Кель", Code = "41703220874060", CoateType = CoateType.Village,
                    ParentId = 146, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1715, Name = "Кыр-Джол", Code = "41703220874070", CoateType = CoateType.Village,
                    ParentId = 146, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1716, Name = "Ладан-Кара", Code = "41703220874080", CoateType = CoateType.Village,
                    ParentId = 146, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1717, Name = "Масадан", Code = "41703220874090", CoateType = CoateType.Village, ParentId = 146,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1718, Name = "Сасык-Булак", Code = "41703220874100", CoateType = CoateType.Village,
                    ParentId = 146, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1719, Name = "Тотия", Code = "41703220874110", CoateType = CoateType.Village, ParentId = 146,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1720, Name = "Чымчык-Джар", Code = "41703220874120", CoateType = CoateType.Village,
                    ParentId = 146, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1721, Name = "Ырыс", Code = "41703220874130", CoateType = CoateType.Village, ParentId = 146,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1722, Name = "Атай", Code = "41703223805020", CoateType = CoateType.Village, ParentId = 147,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1723, Name = "Им. Карла Маркса", Code = "41703223805040", CoateType = CoateType.Village,
                    ParentId = 147, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1724, Name = "Арал", Code = "41703223806010", CoateType = CoateType.Village, ParentId = 148,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1725, Name = "Бирдик", Code = "41703223806020", CoateType = CoateType.Village, ParentId = 148,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1726, Name = "Казарман", Code = "41703223812010", CoateType = CoateType.Village,
                    ParentId = 149, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1727, Name = "Кызыл-Джылдыз", Code = "41703223812020", CoateType = CoateType.Village,
                    ParentId = 149, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1728, Name = "Макмал", Code = "41703223812030", CoateType = CoateType.Village, ParentId = 149,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1729, Name = "Чет-Булак", Code = "41703223812040", CoateType = CoateType.Village,
                    ParentId = 149, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1730, Name = "Кара-Суу", Code = "41703223820010", CoateType = CoateType.Village,
                    ParentId = 150, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1731, Name = "Табылгыты        ", Code = "41703223820020", CoateType = CoateType.Village,
                    ParentId = 150, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1732, Name = "Дедемель", Code = "41703223825010", CoateType = CoateType.Village,
                    ParentId = 151, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1733, Name = "Кош-Булак", Code = "41703223825020", CoateType = CoateType.Village,
                    ParentId = 151, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1734, Name = "Им. Ленина", Code = "41703223825030", CoateType = CoateType.Village,
                    ParentId = 151, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1735, Name = "Орнек", Code = "41703223825040", CoateType = CoateType.Village, ParentId = 151,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1736, Name = "Сары-Сегет", Code = "41703225807010", CoateType = CoateType.Village,
                    ParentId = 152, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1737, Name = "Бель-Алды", Code = "41703225807020", CoateType = CoateType.Village,
                    ParentId = 152, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1738, Name = "Коргон", Code = "41703225807030", CoateType = CoateType.Village, ParentId = 152,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1739, Name = "Джаны-Джол", Code = "41703225815010", CoateType = CoateType.Village,
                    ParentId = 153, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1740, Name = "Арал", Code = "41703225815020", CoateType = CoateType.Village, ParentId = 153,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1741, Name = "Кара-Суу", Code = "41703225815030", CoateType = CoateType.Village,
                    ParentId = 153, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1742, Name = "Комсомол", Code = "41703225815040", CoateType = CoateType.Village,
                    ParentId = 153, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1743, Name = "Им. Куйбышева", Code = "41703225815050", CoateType = CoateType.Village,
                    ParentId = 153, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1744, Name = "Кызыл-Туу", Code = "41703225815060", CoateType = CoateType.Village,
                    ParentId = 153, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1745, Name = "Кызыл-Озгерюш", Code = "41703225820010", CoateType = CoateType.Village,
                    ParentId = 154, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1746, Name = "Ан-Арык", Code = "41703225820020", CoateType = CoateType.Village, ParentId = 154,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1747, Name = "Бель-Кара-Суу", Code = "41703225820030", CoateType = CoateType.Village,
                    ParentId = 154, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1748, Name = "Бууракан", Code = "41703225820040", CoateType = CoateType.Village,
                    ParentId = 154, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1749, Name = "Джар-Таш", Code = "41703225820050", CoateType = CoateType.Village,
                    ParentId = 154, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1750, Name = "Камыш-Башы", Code = "41703225820060", CoateType = CoateType.Village,
                    ParentId = 154, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1751, Name = "Конур-Огюз", Code = "41703225820070", CoateType = CoateType.Village,
                    ParentId = 154, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1752, Name = "Кош-Таш", Code = "41703225820080", CoateType = CoateType.Village, ParentId = 154,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1753, Name = "Орто-Джон", Code = "41703225820100", CoateType = CoateType.Village,
                    ParentId = 154, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1754, Name = "Чеч-Дебе", Code = "41703225820110", CoateType = CoateType.Village,
                    ParentId = 154, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1755, Name = "Шайык", Code = "41703225820130", CoateType = CoateType.Village, ParentId = 154,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1756, Name = "Ак-Жар", Code = "41703225820140", CoateType = CoateType.Village, ParentId = 154,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1757, Name = "Ничке-Сай", Code = "41703225821010", CoateType = CoateType.Village,
                    ParentId = 155, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1758, Name = "Чоргочу", Code = "41703225821020", CoateType = CoateType.Village, ParentId = 155,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1759, Name = "Терек-Суу", Code = "41703225825010", CoateType = CoateType.Village,
                    ParentId = 156, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1760, Name = "Беке-Чал", Code = "41703225825020", CoateType = CoateType.Village,
                    ParentId = 156, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1761, Name = "Чон-Арык", Code = "41703225825030", CoateType = CoateType.Village,
                    ParentId = 156, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1762, Name = "Эшсай", Code = "41703225825040", CoateType = CoateType.Village, ParentId = 156,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1763, Name = "Бирлик", Code = "41703225835010", CoateType = CoateType.Village, ParentId = 157,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1764, Name = "Кетерме", Code = "41703225835020", CoateType = CoateType.Village, ParentId = 157,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1765, Name = "Уч-Терек", Code = "41703225836010", CoateType = CoateType.Village,
                    ParentId = 158, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1766, Name = "Джетиген", Code = "41703225836020", CoateType = CoateType.Village,
                    ParentId = 158, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1767, Name = "Кызыл-Ураан", Code = "41703225836030", CoateType = CoateType.Village,
                    ParentId = 158, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1768, Name = "Саргата", Code = "41703225836040", CoateType = CoateType.Village, ParentId = 158,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1769, Name = "Толук", Code = "41703225840010", CoateType = CoateType.Village, ParentId = 159,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1770, Name = "Алмалуу", Code = "41703225840020", CoateType = CoateType.Village, ParentId = 159,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1771, Name = "Ноот", Code = "41703225840030", CoateType = CoateType.Village, ParentId = 159,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1772, Name = "Чаар-Таш", Code = "41703225840040", CoateType = CoateType.Village,
                    ParentId = 159, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1773, Name = "Торкент", Code = "41703225843010", CoateType = CoateType.Village, ParentId = 160,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1774, Name = "Кетерме", Code = "41703225843020", CoateType = CoateType.Village, ParentId = 160,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1775, Name = "Кара-Джыгач", Code = "41703225843030", CoateType = CoateType.Village,
                    ParentId = 160, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1776, Name = "Чолпон-Ата", Code = "41703225853010", CoateType = CoateType.Village,
                    ParentId = 161, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1777, Name = "Ак-Тектир", Code = "41703225853020", CoateType = CoateType.Village,
                    ParentId = 161, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1778, Name = "Балыкты", Code = "41703225853030", CoateType = CoateType.Village, ParentId = 161,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1779, Name = "Кара-Кюнгей", Code = "41703225853040", CoateType = CoateType.Village,
                    ParentId = 161, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1780, Name = "Кушчу-Суу", Code = "41703225853050", CoateType = CoateType.Village,
                    ParentId = 161, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1781, Name = "Мазар-Суу", Code = "41703225853060", CoateType = CoateType.Village,
                    ParentId = 161, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1782, Name = "Каныш-Кыя", Code = "41703230822010", CoateType = CoateType.Village,
                    ParentId = 162, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1783, Name = "Айгыр-Джал", Code = "41703230822020", CoateType = CoateType.Village,
                    ParentId = 162, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1784, Name = "Башкы-Терек", Code = "41703230822030", CoateType = CoateType.Village,
                    ParentId = 162, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1785, Name = "Коргон-Сай", Code = "41703230822040", CoateType = CoateType.Village,
                    ParentId = 162, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1786, Name = "Кызыл-Токой", Code = "41703230822050", CoateType = CoateType.Village,
                    ParentId = 162, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1787, Name = "Чакмак-Суу", Code = "41703230822060", CoateType = CoateType.Village,
                    ParentId = 162, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1788, Name = "Джаны-Базар", Code = "41703230841010", CoateType = CoateType.Village,
                    ParentId = 163, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1789, Name = "Ак-Таш", Code = "41703230841020", CoateType = CoateType.Village, ParentId = 163,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1790, Name = "Беш-Арал", Code = "41703230841030", CoateType = CoateType.Village,
                    ParentId = 163, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1791, Name = "Курулуш              ", Code = "41703230841040", CoateType = CoateType.Village,
                    ParentId = 163, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1792, Name = "Сумсар", Code = "41703230844010", CoateType = CoateType.Village, ParentId = 164,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1793, Name = "Терек-Сай", Code = "41703230847010", CoateType = CoateType.Village,
                    ParentId = 165, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1794, Name = "Кызыл-Токой", Code = "41703230847011", CoateType = CoateType.Village,
                    ParentId = 165, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1795, Name = "Сопу-Коргон", Code = "41706207804010", CoateType = CoateType.Village,
                    ParentId = 291, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1796, Name = "Аскалы", Code = "41706207804020", CoateType = CoateType.Village, ParentId = 291,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1797, Name = "Джергетал", Code = "41706207804030", CoateType = CoateType.Village,
                    ParentId = 291, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1798, Name = "Колдук", Code = "41706207804040", CoateType = CoateType.Village, ParentId = 291,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1799, Name = "Таргалак", Code = "41706207804050", CoateType = CoateType.Village,
                    ParentId = 291, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1800, Name = "Терек", Code = "41706207804060", CoateType = CoateType.Village, ParentId = 291,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1801, Name = "Чий-Талаа", Code = "41706207804070", CoateType = CoateType.Village,
                    ParentId = 291, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1802, Name = "Кара-Суу", Code = "41706207809010", CoateType = CoateType.Village,
                    ParentId = 292, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1803, Name = "Кайнама", Code = "41706207809020", CoateType = CoateType.Village, ParentId = 292,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1804, Name = "Тамга-Терек", Code = "41706207809030", CoateType = CoateType.Village,
                    ParentId = 292, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1805, Name = "Кум-Шоро", Code = "41706207809040", CoateType = CoateType.Village,
                    ParentId = 292, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1806, Name = "Октябрь", Code = "41706207809050", CoateType = CoateType.Village, ParentId = 292,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1807, Name = "Оро-Дебе", Code = "41706207809060", CoateType = CoateType.Village,
                    ParentId = 292, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1808, Name = "Кошулуш", Code = "41706207811010", CoateType = CoateType.Village, ParentId = 293,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1809, Name = "Кичи-Бюлелю", Code = "41706207811020", CoateType = CoateType.Village,
                    ParentId = 293, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1810, Name = "Кел-Чаты", Code = "41706207811030", CoateType = CoateType.Village,
                    ParentId = 293, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1811, Name = "Чон-Бюлелю", Code = "41706207811040", CoateType = CoateType.Village,
                    ParentId = 293, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1812, Name = "Гульча", Code = "41706207814010", CoateType = CoateType.Village, ParentId = 294,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1813, Name = "Кара-Булак", Code = "41706207814020", CoateType = CoateType.Village,
                    ParentId = 294, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1814, Name = "Жылы-Суу", Code = "41706207814030", CoateType = CoateType.Village,
                    ParentId = 294, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1815, Name = "Таш-Короо", Code = "41706207814040", CoateType = CoateType.Village,
                    ParentId = 294, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1816, Name = "Чакмак", Code = "41706207814050", CoateType = CoateType.Village, ParentId = 294,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1817, Name = "Курманжан Датка", Code = "41706207814060", CoateType = CoateType.Village,
                    ParentId = 294, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1818, Name = "Джаны-Турмуш", Code = "41706207818010", CoateType = CoateType.Village,
                    ParentId = 295, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1819, Name = "Аюу-Тапан", Code = "41706207818020", CoateType = CoateType.Village,
                    ParentId = 295, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1820, Name = "Коммунизм", Code = "41706207818030", CoateType = CoateType.Village,
                    ParentId = 295, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1821, Name = "Ленин-Джол", Code = "41706207818040", CoateType = CoateType.Village,
                    ParentId = 295, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1822, Name = "Миязды", Code = "41706207818050", CoateType = CoateType.Village, ParentId = 295,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1823, Name = "Орто-Суу", Code = "41706207818060", CoateType = CoateType.Village,
                    ParentId = 295, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1824, Name = "Осоавиахим", Code = "41706207818070", CoateType = CoateType.Village,
                    ParentId = 295, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1825, Name = "Боз-Караган", Code = "41706207822010", CoateType = CoateType.Village,
                    ParentId = 296, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1826, Name = "Джар-Кыштак", Code = "41706207822020", CoateType = CoateType.Village,
                    ParentId = 296, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1827, Name = "Кара-Шоро", Code = "41706207822040", CoateType = CoateType.Village,
                    ParentId = 296, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1828, Name = "Арпа-Тектир", Code = "41706207822050", CoateType = CoateType.Village,
                    ParentId = 296, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1829, Name = "Кызыл-Ой", Code = "41706207822060", CoateType = CoateType.Village,
                    ParentId = 296, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1830, Name = "Кабылан-Кол", Code = "41706207823010", CoateType = CoateType.Village,
                    ParentId = 297, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1831, Name = "Кунгей", Code = "41706207823020", CoateType = CoateType.Village, ParentId = 297,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1832, Name = "Кара-Жыгач", Code = "41706207823030", CoateType = CoateType.Village,
                    ParentId = 297, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1833, Name = "Курулуш", Code = "41706207823040", CoateType = CoateType.Village, ParentId = 297,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1834, Name = "Тогуз-Булак", Code = "41706207825010", CoateType = CoateType.Village,
                    ParentId = 298, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1835, Name = "Кен-Джылга", Code = "41706207825020", CoateType = CoateType.Village,
                    ParentId = 298, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1836, Name = "Первое Мая", Code = "41706207825030", CoateType = CoateType.Village,
                    ParentId = 298, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1837, Name = "Им. Гагарина", Code = "41706207830020", CoateType = CoateType.Village,
                    ParentId = 299, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1838, Name = "Кун-Элек", Code = "41706207830030", CoateType = CoateType.Village,
                    ParentId = 299, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1839, Name = "Мурдаш", Code = "41706207830040", CoateType = CoateType.Village, ParentId = 299,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1840, Name = "Согонду", Code = "41706207830050", CoateType = CoateType.Village, ParentId = 299,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1841, Name = "Талды-Суу", Code = "41706207838010", CoateType = CoateType.Village,
                    ParentId = 300, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1842, Name = "Арча-Булак", Code = "41706207838020", CoateType = CoateType.Village,
                    ParentId = 300, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1843, Name = "Кек-Булак", Code = "41706207838030", CoateType = CoateType.Village,
                    ParentId = 300, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1844, Name = "Кургак", Code = "41706207838040", CoateType = CoateType.Village, ParentId = 300,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1845, Name = "Сары-Могол", Code = "41706207838050", CoateType = CoateType.Village,
                    ParentId = 300, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1846, Name = "Сары-Могол", Code = "41706207839010", CoateType = CoateType.Village,
                    ParentId = 301, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1847, Name = "Кичи-Каракол", Code = "41706207840010", CoateType = CoateType.Village,
                    ParentId = 302, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1848, Name = "Ак-Босого", Code = "41706207840020", CoateType = CoateType.Village,
                    ParentId = 302, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1849, Name = "Ак-Джай", Code = "41706207840030", CoateType = CoateType.Village, ParentId = 302,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1850, Name = "Геджиге", Code = "41706207840040", CoateType = CoateType.Village, ParentId = 302,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1851, Name = "Кызыл-Алай", Code = "41706207840050", CoateType = CoateType.Village,
                    ParentId = 302, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1852, Name = "Чон-Каракол", Code = "41706207840060", CoateType = CoateType.Village,
                    ParentId = 302, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1853, Name = "Жаны-Алай", Code = "41706207841010", CoateType = CoateType.Village,
                    ParentId = 303, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1854, Name = "Жаны-Арык", Code = "41706207841020", CoateType = CoateType.Village,
                    ParentId = 303, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1855, Name = "Сары-Таш", Code = "41706207844010", CoateType = CoateType.Village,
                    ParentId = 304, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1856, Name = "Кек-Суу", Code = "41706207844020", CoateType = CoateType.Village, ParentId = 304,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1857, Name = "Нура", Code = "41706207844030", CoateType = CoateType.Village, ParentId = 304,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1858, Name = "Араван", Code = "41706211807010", CoateType = CoateType.Village, ParentId = 305,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1859, Name = "Аччи", Code = "41706211807020", CoateType = CoateType.Village, ParentId = 305,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1860, Name = "Кара-Булак", Code = "41706211807040", CoateType = CoateType.Village,
                    ParentId = 305, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1861, Name = "Сасык-Ункюр", Code = "41706211807060", CoateType = CoateType.Village,
                    ParentId = 305, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1862, Name = "Жаны-Араван", Code = "41706211807090", CoateType = CoateType.Village,
                    ParentId = 305, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1863, Name = "Каррак", Code = "41706211809010", CoateType = CoateType.Village, ParentId = 306,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1864, Name = "Октябрь", Code = "41706211809020", CoateType = CoateType.Village, ParentId = 306,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1865, Name = "Эрке-Кашка", Code = "41706211809030", CoateType = CoateType.Village,
                    ParentId = 306, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1866, Name = "Суткор", Code = "41706211809040", CoateType = CoateType.Village, ParentId = 306,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1867, Name = "Араван", Code = "41706211809050", CoateType = CoateType.Village, ParentId = 306,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1868, Name = "Мангит", Code = "41706211812010", CoateType = CoateType.Village, ParentId = 307,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1869, Name = "Кесек", Code = "41706211812020", CoateType = CoateType.Village, ParentId = 307,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1870, Name = "Кызыл-Коргон", Code = "41706211812030", CoateType = CoateType.Village,
                    ParentId = 307, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1871, Name = "Телейкен", Code = "41706211812040", CoateType = CoateType.Village,
                    ParentId = 307, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1872, Name = "Жаны-Арык", Code = "41706211812050", CoateType = CoateType.Village,
                    ParentId = 307, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1873, Name = "Гюльбахор", Code = "41706211815010", CoateType = CoateType.Village,
                    ParentId = 308, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1874, Name = "Кичик-Алай", Code = "41706211815020", CoateType = CoateType.Village,
                    ParentId = 308, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1875, Name = "Кюнделюк", Code = "41706211815030", CoateType = CoateType.Village,
                    ParentId = 308, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1876, Name = "Майдан-Тал", Code = "41706211815040", CoateType = CoateType.Village,
                    ParentId = 308, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1877, Name = "Мин-Теке", Code = "41706211815050", CoateType = CoateType.Village,
                    ParentId = 308, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1878, Name = "Сары-Булак", Code = "41706211815060", CoateType = CoateType.Village,
                    ParentId = 308, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1879, Name = "Чогом", Code = "41706211815070", CoateType = CoateType.Village, ParentId = 308,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1880, Name = "Тепе-Коргон", Code = "41706211823010", CoateType = CoateType.Village,
                    ParentId = 309, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1881, Name = "Арап", Code = "41706211823020", CoateType = CoateType.Village, ParentId = 309,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1882, Name = "Интернационал", Code = "41706211823030", CoateType = CoateType.Village,
                    ParentId = 309, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1883, Name = "Кесов", Code = "41706211823060", CoateType = CoateType.Village, ParentId = 309,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1884, Name = "Уйгур-Абад", Code = "41706211823080", CoateType = CoateType.Village,
                    ParentId = 309, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1885, Name = "Чертик", Code = "41706211823090", CoateType = CoateType.Village, ParentId = 309,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1886, Name = "Янги-Абад", Code = "41706211823100", CoateType = CoateType.Village,
                    ParentId = 309, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1887, Name = "Янги-Юль", Code = "41706211823110", CoateType = CoateType.Village,
                    ParentId = 309, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1888, Name = "Кайрагач-Арык", Code = "41706211824010", CoateType = CoateType.Village,
                    ParentId = 310, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1889, Name = "Какыр-Пилтан", Code = "41706211824020", CoateType = CoateType.Village,
                    ParentId = 310, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1890, Name = "Лангар", Code = "41706211824030", CoateType = CoateType.Village, ParentId = 310,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1891, Name = "Хауз", Code = "41706211829010", CoateType = CoateType.Village, ParentId = 311,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1892, Name = "Ак-Шор", Code = "41706211829020", CoateType = CoateType.Village, ParentId = 311,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1893, Name = "Джеке-Мисте", Code = "41706211829030", CoateType = CoateType.Village,
                    ParentId = 311, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1894, Name = "Керкидан", Code = "41706211829040", CoateType = CoateType.Village,
                    ParentId = 311, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1895, Name = "Найман", Code = "41706211829050", CoateType = CoateType.Village, ParentId = 311,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1896, Name = "Сары-Таш", Code = "41706211829060", CoateType = CoateType.Village,
                    ParentId = 311, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1897, Name = "Сырт", Code = "41706211829070", CoateType = CoateType.Village, ParentId = 311,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1898, Name = "Кочубаево", Code = "41706211835010", CoateType = CoateType.Village,
                    ParentId = 312, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1899, Name = "Агроном", Code = "41706211835020", CoateType = CoateType.Village, ParentId = 312,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1900, Name = "Джакшылык", Code = "41706211835030", CoateType = CoateType.Village,
                    ParentId = 312, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1901, Name = "Джар-Кышлак", Code = "41706211835040", CoateType = CoateType.Village,
                    ParentId = 312, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1902, Name = "Кукалапаш", Code = "41706211835050", CoateType = CoateType.Village,
                    ParentId = 312, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1903, Name = "Максим-Тобу", Code = "41706211835060", CoateType = CoateType.Village,
                    ParentId = 312, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1904, Name = "Пахтачи", Code = "41706211835070", CoateType = CoateType.Village, ParentId = 312,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1905, Name = "Телейкен", Code = "41706211835080", CoateType = CoateType.Village,
                    ParentId = 312, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1906, Name = "Ак-Таш", Code = "41706226804010", CoateType = CoateType.Village, ParentId = 325,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1907, Name = "Жылкелди", Code = "41706226804020", CoateType = CoateType.Village,
                    ParentId = 325, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1908, Name = "Барак", Code = "41706226804030", CoateType = CoateType.Village, ParentId = 325,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1909, Name = "Джаны-Арык", Code = "41706226806010", CoateType = CoateType.Village,
                    ParentId = 326, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1910, Name = "Ак-Терек", Code = "41706226806020", CoateType = CoateType.Village,
                    ParentId = 326, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1911, Name = "Правда", Code = "41706226806030", CoateType = CoateType.Village, ParentId = 326,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1912, Name = "Таш-Арык", Code = "41706226806040", CoateType = CoateType.Village,
                    ParentId = 326, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1913, Name = "Большевик", Code = "41706226807010", CoateType = CoateType.Village,
                    ParentId = 327, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1914, Name = "Агартуу", Code = "41706226807020", CoateType = CoateType.Village, ParentId = 327,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1915, Name = "Гайрат", Code = "41706226807030", CoateType = CoateType.Village, ParentId = 327,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1916, Name = "Зарбалик", Code = "41706226807040", CoateType = CoateType.Village,
                    ParentId = 327, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1917, Name = "Им. Калинина", Code = "41706226807050", CoateType = CoateType.Village,
                    ParentId = 327, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1918, Name = "Коммунизм", Code = "41706226807060", CoateType = CoateType.Village,
                    ParentId = 327, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1919, Name = "Кызыл-Кошчу", Code = "41706226807070", CoateType = CoateType.Village,
                    ParentId = 327, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1920, Name = "Кызыл-Сарай", Code = "41706226807080", CoateType = CoateType.Village,
                    ParentId = 327, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1921, Name = "Маданият", Code = "41706226807090", CoateType = CoateType.Village,
                    ParentId = 327, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1922, Name = "Мамажан", Code = "41706226807100", CoateType = CoateType.Village, ParentId = 327,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1923, Name = "Питомник", Code = "41706226807110", CoateType = CoateType.Village,
                    ParentId = 327, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1924, Name = "Баш-Булак", Code = "41706226812010", CoateType = CoateType.Village,
                    ParentId = 328, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1925, Name = "Джаны-Турмуш", Code = "41706226812020", CoateType = CoateType.Village,
                    ParentId = 328, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1926, Name = "Кара-Сегет", Code = "41706226812030", CoateType = CoateType.Village,
                    ParentId = 328, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1927, Name = "Талдык", Code = "41706226812040", CoateType = CoateType.Village, ParentId = 328,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1928, Name = "Кичик", Code = "41706226812050", CoateType = CoateType.Village, ParentId = 328,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1929, Name = "Кызыл-Ордо", Code = "41706226812060", CoateType = CoateType.Village,
                    ParentId = 328, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1930, Name = "Садырбай", Code = "41706226812070", CoateType = CoateType.Village,
                    ParentId = 328, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1931, Name = "Эшме", Code = "41706226812080", CoateType = CoateType.Village, ParentId = 328,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1932, Name = "Ачы", Code = "41706226812090", CoateType = CoateType.Village, ParentId = 328,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1933, Name = "Кашгар-Кыштак", Code = "41706226816010", CoateType = CoateType.Village,
                    ParentId = 329, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1934, Name = "Алга-Бас", Code = "41706226816020", CoateType = CoateType.Village,
                    ParentId = 329, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1935, Name = "Андижан-Махалла", Code = "41706226816030", CoateType = CoateType.Village,
                    ParentId = 329, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1936, Name = "Бек-Джар", Code = "41706226816040", CoateType = CoateType.Village,
                    ParentId = 329, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1937, Name = "Джар-Ооз", Code = "41706226816050", CoateType = CoateType.Village,
                    ParentId = 329, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1938, Name = "Кенджекул", Code = "41706226816060", CoateType = CoateType.Village,
                    ParentId = 329, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1939, Name = "Таджик-Махалла", Code = "41706226816070", CoateType = CoateType.Village,
                    ParentId = 329, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1940, Name = "Монок", Code = "41706226816080", CoateType = CoateType.Village, ParentId = 329,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1941, Name = "Кызыл-Кыштак", Code = "41706226819010", CoateType = CoateType.Village,
                    ParentId = 330, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1942, Name = "Андижанское", Code = "41706226819020", CoateType = CoateType.Village,
                    ParentId = 330, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1943, Name = "Бель-Кыштак", Code = "41706226819030", CoateType = CoateType.Village,
                    ParentId = 330, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1944, Name = "Джаны-Кыштак", Code = "41706226819040", CoateType = CoateType.Village,
                    ParentId = 330, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1945, Name = "Им. Карла Маркса", Code = "41706226819050", CoateType = CoateType.Village,
                    ParentId = 330, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1946, Name = "Коммунист", Code = "41706226819060", CoateType = CoateType.Village,
                    ParentId = 330, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1947, Name = "Кызыл-Байрак", Code = "41706226819070", CoateType = CoateType.Village,
                    ParentId = 330, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1948, Name = "Чайчи", Code = "41706226822010", CoateType = CoateType.Village, ParentId = 331,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1949, Name = "Ак-Джар", Code = "41706226822020", CoateType = CoateType.Village, ParentId = 331,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1950, Name = "Коргон", Code = "41706226822030", CoateType = CoateType.Village, ParentId = 331,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1951, Name = "Миялы", Code = "41706226822040", CoateType = CoateType.Village, ParentId = 331,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1952, Name = "Алпордо", Code = "41706226822050", CoateType = CoateType.Village, ParentId = 331,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1953, Name = "Талаа", Code = "41706226822060", CoateType = CoateType.Village, ParentId = 331,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1954, Name = "Учкун", Code = "41706226822070", CoateType = CoateType.Village, ParentId = 331,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1955, Name = "Кыргыз-Чек", Code = "41706226826010", CoateType = CoateType.Village,
                    ParentId = 332, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1956, Name = "Асанчек", Code = "41706226826020", CoateType = CoateType.Village, ParentId = 332,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1957, Name = "Жоош", Code = "41706226826030", CoateType = CoateType.Village, ParentId = 332,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1958, Name = "Каарман", Code = "41706226826040", CoateType = CoateType.Village, ParentId = 332,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1959, Name = "Лаглан", Code = "41706226826050", CoateType = CoateType.Village, ParentId = 332,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1960, Name = "Мады", Code = "41706226826060", CoateType = CoateType.Village, ParentId = 332,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1961, Name = "Октябрь", Code = "41706226826070", CoateType = CoateType.Village, ParentId = 332,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1962, Name = "Социализм", Code = "41706226826080", CoateType = CoateType.Village,
                    ParentId = 332, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1963, Name = "Тээке", Code = "41706226826090", CoateType = CoateType.Village, ParentId = 332,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1964, Name = "Учкун", Code = "41706226826100", CoateType = CoateType.Village, ParentId = 332,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1965, Name = "Чагыр", Code = "41706226826110", CoateType = CoateType.Village, ParentId = 332,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1966, Name = "Нариман", Code = "41706226830010", CoateType = CoateType.Village, ParentId = 333,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1967, Name = "Алим-Тепе", Code = "41706226830020", CoateType = CoateType.Village,
                    ParentId = 333, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1968, Name = "Бешмойнок", Code = "41706226830030", CoateType = CoateType.Village,
                    ParentId = 333, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1969, Name = "Влксм", Code = "41706226830040", CoateType = CoateType.Village, ParentId = 333,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1970, Name = "Джаны-Махалла", Code = "41706226830050", CoateType = CoateType.Village,
                    ParentId = 333, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1971, Name = "Джийдалик", Code = "41706226830060", CoateType = CoateType.Village,
                    ParentId = 333, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1972, Name = "Каратай", Code = "41706226830070", CoateType = CoateType.Village, ParentId = 333,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1973, Name = "Осмон", Code = "41706226830080", CoateType = CoateType.Village, ParentId = 333,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1974, Name = "Куранкол", Code = "41706226830090", CoateType = CoateType.Village,
                    ParentId = 333, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1975, Name = "Кызыл-Мехнат", Code = "41706226830100", CoateType = CoateType.Village,
                    ParentId = 333, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1976, Name = "Лангар", Code = "41706226830110", CoateType = CoateType.Village, ParentId = 333,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1977, Name = "Нурдар", Code = "41706226830120", CoateType = CoateType.Village, ParentId = 333,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1978, Name = "Жим", Code = "41706226830130", CoateType = CoateType.Village, ParentId = 333,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1979, Name = "Тажикабад", Code = "41706226830140", CoateType = CoateType.Village,
                    ParentId = 333, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1980, Name = "Отуз-Адыр", Code = "41706226838010", CoateType = CoateType.Village,
                    ParentId = 334, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1981, Name = "Кара-Дебе", Code = "41706226838030", CoateType = CoateType.Village,
                    ParentId = 334, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1982, Name = "Кызыл-Абад", Code = "41706226838050", CoateType = CoateType.Village,
                    ParentId = 334, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1983, Name = "Кыш-Абад", Code = "41706226838060", CoateType = CoateType.Village,
                    ParentId = 334, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1984, Name = "Савай-Арык", Code = "41706226838070", CoateType = CoateType.Village,
                    ParentId = 334, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1985, Name = "Фурхат", Code = "41706226838090", CoateType = CoateType.Village, ParentId = 334,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1986, Name = "Ынтымак", Code = "41706226838100", CoateType = CoateType.Village, ParentId = 334,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1987, Name = "Жаны-Кызыл-Суу", Code = "41706226838110", CoateType = CoateType.Village,
                    ParentId = 334, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1988, Name = "Тынчтык", Code = "41706226838120", CoateType = CoateType.Village, ParentId = 334,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1989, Name = "Сары-Колот", Code = "41706226840010", CoateType = CoateType.Village,
                    ParentId = 335, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1990, Name = "Ак-Колот", Code = "41706226840020", CoateType = CoateType.Village,
                    ParentId = 335, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1991, Name = "Курбан-Кара", Code = "41706226840030", CoateType = CoateType.Village,
                    ParentId = 335, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1992, Name = "Шерали", Code = "41706226840040", CoateType = CoateType.Village, ParentId = 335,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1993, Name = "Присавай", Code = "41706226840050", CoateType = CoateType.Village,
                    ParentId = 335, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1994, Name = "Тынчтык", Code = "41706226840060", CoateType = CoateType.Village, ParentId = 335,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1995, Name = "Папан", Code = "41706226842010", CoateType = CoateType.Village, ParentId = 336,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1996, Name = "Ак-Терек", Code = "41706226842020", CoateType = CoateType.Village,
                    ParentId = 336, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1997, Name = "Алчалы", Code = "41706226842030", CoateType = CoateType.Village, ParentId = 336,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1998, Name = "Ата-Мерек", Code = "41706226842040", CoateType = CoateType.Village,
                    ParentId = 336, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 1999, Name = "Берю", Code = "41706226842050", CoateType = CoateType.Village, ParentId = 336,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2000, Name = "Карагур", Code = "41706226842060", CoateType = CoateType.Village, ParentId = 336,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2001, Name = "Коджо-Келен", Code = "41706226842070", CoateType = CoateType.Village,
                    ParentId = 336, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2002, Name = "Кызыл-Туу", Code = "41706226842080", CoateType = CoateType.Village,
                    ParentId = 336, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2003, Name = "Тогуз-Булак", Code = "41706226842090", CoateType = CoateType.Village,
                    ParentId = 336, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2004, Name = "Ак-Буура-1", Code = "41706226842100", CoateType = CoateType.Village,
                    ParentId = 336, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2005, Name = "Ак-Буура-2", Code = "41706226842110", CoateType = CoateType.Village,
                    ParentId = 336, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2006, Name = "Ак-Буура-3", Code = "41706226842120", CoateType = CoateType.Village,
                    ParentId = 336, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2007, Name = "Ак-Буура-4", Code = "41706226842130", CoateType = CoateType.Village,
                    ParentId = 336, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2008, Name = "Камыр-Суу", Code = "41706226842140", CoateType = CoateType.Village,
                    ParentId = 336, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2009, Name = "Жар-Башы", Code = "41706226842150", CoateType = CoateType.Village,
                    ParentId = 336, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2010, Name = "Чычкан-Кол", Code = "41706226842160", CoateType = CoateType.Village,
                    ParentId = 336, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2011, Name = "Андагул", Code = "41706226842170", CoateType = CoateType.Village, ParentId = 336,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2012, Name = "Жаны-Турмуш", Code = "41706226842180", CoateType = CoateType.Village,
                    ParentId = 336, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2013, Name = "Кызыл-Шарк", Code = "41706226850010", CoateType = CoateType.Village,
                    ParentId = 337, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2014, Name = "Кен-Сай", Code = "41706226850020", CoateType = CoateType.Village, ParentId = 337,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2015, Name = "Кечкен-Джар", Code = "41706226850030", CoateType = CoateType.Village,
                    ParentId = 337, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2016, Name = "Курбан-Кара", Code = "41706226850040", CoateType = CoateType.Village,
                    ParentId = 337, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2017, Name = "Кыдырша", Code = "41706226850050", CoateType = CoateType.Village, ParentId = 337,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2018, Name = "Октябрь", Code = "41706226850060", CoateType = CoateType.Village, ParentId = 337,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2019, Name = "Ынтымак", Code = "41706226850070", CoateType = CoateType.Village, ParentId = 337,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2020, Name = "Савай", Code = "41706226850080", CoateType = CoateType.Village, ParentId = 337,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2021, Name = "Султан-Абад", Code = "41706226850090", CoateType = CoateType.Village,
                    ParentId = 337, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2022, Name = "Им. Кирова", Code = "41706226854010", CoateType = CoateType.Village,
                    ParentId = 338, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2023, Name = "Эркин", Code = "41706226854020", CoateType = CoateType.Village, ParentId = 338,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2024, Name = "Присавай", Code = "41706226854030", CoateType = CoateType.Village,
                    ParentId = 338, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2025, Name = "Конурат", Code = "41706226854040", CoateType = CoateType.Village, ParentId = 338,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2026, Name = "Им. Тельмана", Code = "41706226854050", CoateType = CoateType.Village,
                    ParentId = 338, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2027, Name = "Дыйкан-Кыштак", Code = "41706226862010", CoateType = CoateType.Village,
                    ParentId = 339, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2028, Name = "Кыргызстан", Code = "41706226862020", CoateType = CoateType.Village,
                    ParentId = 339, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2029, Name = "Озгур (часть)", Code = "41706226862030", CoateType = CoateType.Village,
                    ParentId = 339, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2030, Name = "Телейкен (часть)", Code = "41706226862040", CoateType = CoateType.Village,
                    ParentId = 339, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2031, Name = "Учар", Code = "41706226862050", CoateType = CoateType.Village, ParentId = 339,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2032, Name = "Шарк", Code = "41706226868010", CoateType = CoateType.Village, ParentId = 340,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2033, Name = "Таштак", Code = "41706226868020", CoateType = CoateType.Village, ParentId = 340,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2034, Name = "Имам-Ата", Code = "41706226868030", CoateType = CoateType.Village,
                    ParentId = 340, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2035, Name = "Маданият", Code = "41706226868040", CoateType = CoateType.Village,
                    ParentId = 340, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2036, Name = "Топ-Терек", Code = "41706226868050", CoateType = CoateType.Village,
                    ParentId = 340, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2037, Name = "Фуркат", Code = "41706226868060", CoateType = CoateType.Village, ParentId = 340,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2038, Name = "Бель", Code = "41706242808010", CoateType = CoateType.Village, ParentId = 341,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2039, Name = "Борбаш", Code = "41706242808020", CoateType = CoateType.Village, ParentId = 341,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2040, Name = "Им. Фрунзе (часть)", Code = "41706242811010", CoateType = CoateType.Village,
                    ParentId = 342, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2041, Name = "Гюльстан", Code = "41706242811020", CoateType = CoateType.Village,
                    ParentId = 342, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2042, Name = "Кара-Таш     ", Code = "41706242812010", CoateType = CoateType.Village,
                    ParentId = 343, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2043, Name = "Нойгут", Code = "41706242812020", CoateType = CoateType.Village, ParentId = 343,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2044, Name = "Коджо-Арык", Code = "41706242813010", CoateType = CoateType.Village,
                    ParentId = 344, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2045, Name = "Акчал", Code = "41706242813020", CoateType = CoateType.Village, ParentId = 344,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2046, Name = "Баглан", Code = "41706242813030", CoateType = CoateType.Village, ParentId = 344,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2047, Name = "Кош-Дебе", Code = "41706242813050", CoateType = CoateType.Village,
                    ParentId = 344, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2048, Name = "Кызыл-Булак", Code = "41706242813060", CoateType = CoateType.Village,
                    ParentId = 344, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2049, Name = "Джаны-Ноокат", Code = "41706242814010", CoateType = CoateType.Village,
                    ParentId = 345, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2050, Name = "Кызыл-Тейит", Code = "41706242814020", CoateType = CoateType.Village,
                    ParentId = 345, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2051, Name = "Темир-Корук", Code = "41706242814030", CoateType = CoateType.Village,
                    ParentId = 345, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2052, Name = "Куу-Майдан", Code = "41706242825010", CoateType = CoateType.Village,
                    ParentId = 346, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2053, Name = "Ак-Терек", Code = "41706242825020", CoateType = CoateType.Village,
                    ParentId = 346, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2054, Name = "Арбын", Code = "41706242825030", CoateType = CoateType.Village, ParentId = 346,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2055, Name = "Чегеден", Code = "41706242825040", CoateType = CoateType.Village, ParentId = 346,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2056, Name = "Шанкол", Code = "41706242825050", CoateType = CoateType.Village, ParentId = 346,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2057, Name = "Кетерме", Code = "41706242829010", CoateType = CoateType.Village, ParentId = 347,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2058, Name = "Борко", Code = "41706242829020", CoateType = CoateType.Village, ParentId = 347,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2059, Name = "Кара-Ой", Code = "41706242829030", CoateType = CoateType.Village, ParentId = 347,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2060, Name = "Кара-Таш", Code = "41706242829040", CoateType = CoateType.Village,
                    ParentId = 347, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2061, Name = "Кыргыз-Ата", Code = "41706242829050", CoateType = CoateType.Village,
                    ParentId = 347, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2062, Name = "Таш-Булак", Code = "41706242829060", CoateType = CoateType.Village,
                    ParentId = 347, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2063, Name = "Ак-Булак", Code = "41706242829070", CoateType = CoateType.Village,
                    ParentId = 347, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2064, Name = "Учбай", Code = "41706242832010", CoateType = CoateType.Village, ParentId = 348,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2065, Name = "Айбек    ", Code = "41706242832020", CoateType = CoateType.Village,
                    ParentId = 348, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2066, Name = "Ак-Чабуу", Code = "41706242832030", CoateType = CoateType.Village,
                    ParentId = 348, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2067, Name = "Интернационал", Code = "41706242832040", CoateType = CoateType.Village,
                    ParentId = 348, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2068, Name = "Караке", Code = "41706242832050", CoateType = CoateType.Village, ParentId = 348,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2069, Name = "Коммунизм", Code = "41706242832060", CoateType = CoateType.Village,
                    ParentId = 348, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2070, Name = "Осор", Code = "41706242832070", CoateType = CoateType.Village, ParentId = 348,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2071, Name = "Таштак", Code = "41706242832080", CoateType = CoateType.Village, ParentId = 348,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2072, Name = "Чучук", Code = "41706242832090", CoateType = CoateType.Village, ParentId = 348,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2073, Name = "Ятан", Code = "41706242832100", CoateType = CoateType.Village, ParentId = 348,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2074, Name = "Джаны-Базар", Code = "41706242836010", CoateType = CoateType.Village,
                    ParentId = 349, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2075, Name = "Джар-Коргон", Code = "41706242836020", CoateType = CoateType.Village,
                    ParentId = 349, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2076, Name = "Федорово", Code = "41706242836040", CoateType = CoateType.Village,
                    ParentId = 349, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2077, Name = "Чеч-Дебе", Code = "41706242836050", CoateType = CoateType.Village,
                    ParentId = 349, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2078, Name = "Коджоке", Code = "41706242836060", CoateType = CoateType.Village, ParentId = 349,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2079, Name = "Кок-Бель", Code = "41706242838010", CoateType = CoateType.Village,
                    ParentId = 350, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2080, Name = "Кайынды", Code = "41706242838020", CoateType = CoateType.Village, ParentId = 350,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2081, Name = "Кек-Джар", Code = "41706242839010", CoateType = CoateType.Village,
                    ParentId = 351, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2082, Name = "Алашан", Code = "41706242839020", CoateType = CoateType.Village, ParentId = 351,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2083, Name = "Борбаш", Code = "41706242839030", CoateType = CoateType.Village, ParentId = 351,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2084, Name = "Джийде", Code = "41706242839040", CoateType = CoateType.Village, ParentId = 351,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2085, Name = "Каранай", Code = "41706242839050", CoateType = CoateType.Village, ParentId = 351,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2086, Name = "Сарыканды", Code = "41706242839060", CoateType = CoateType.Village,
                    ParentId = 351, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2087, Name = "Он Эки-Бель", Code = "41706242845010", CoateType = CoateType.Village,
                    ParentId = 352, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2088, Name = "Нарай", Code = "41706242845020", CoateType = CoateType.Village, ParentId = 352,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2089, Name = "Муркут", Code = "41706242850010", CoateType = CoateType.Village, ParentId = 353,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2090, Name = "Ай-Тамга", Code = "41706242850020", CoateType = CoateType.Village,
                    ParentId = 353, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2091, Name = "Герей-Шорон", Code = "41706242850030", CoateType = CoateType.Village,
                    ParentId = 353, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2092, Name = "Джайылма", Code = "41706242850040", CoateType = CoateType.Village,
                    ParentId = 353, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2093, Name = "Додон", Code = "41706242850050", CoateType = CoateType.Village, ParentId = 353,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2094, Name = "Кенеш", Code = "41706242850060", CoateType = CoateType.Village, ParentId = 353,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2095, Name = "Меркит", Code = "41706242850070", CoateType = CoateType.Village, ParentId = 353,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2096, Name = "Толман", Code = "41706242850080", CoateType = CoateType.Village, ParentId = 353,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2097, Name = "Им. Чапаева", Code = "41706242856010", CoateType = CoateType.Village,
                    ParentId = 354, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2098, Name = "Арал", Code = "41706242856020", CoateType = CoateType.Village, ParentId = 354,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2099, Name = "Барын", Code = "41706242856030", CoateType = CoateType.Village, ParentId = 354,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2100, Name = "Будайлык", Code = "41706242856040", CoateType = CoateType.Village,
                    ParentId = 354, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2101, Name = "Капчыгай", Code = "41706242856050", CoateType = CoateType.Village,
                    ParentId = 354, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2102, Name = "Кара-Кокту", Code = "41706242856060", CoateType = CoateType.Village,
                    ParentId = 354, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2103, Name = "Ынтымак", Code = "41706242862010", CoateType = CoateType.Village, ParentId = 355,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2104, Name = "Беш-Буркан", Code = "41706242862020", CoateType = CoateType.Village,
                    ParentId = 355, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2105, Name = "Арык-Бою", Code = "41706242862030", CoateType = CoateType.Village,
                    ParentId = 355, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2106, Name = "Дон-Маала", Code = "41706242862040", CoateType = CoateType.Village,
                    ParentId = 355, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2107, Name = "Акшар", Code = "41706242862050", CoateType = CoateType.Village, ParentId = 355,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2108, Name = "Таш-Булак", Code = "41706242862060", CoateType = CoateType.Village,
                    ParentId = 355, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2109, Name = "Челекчи", Code = "41706242862070", CoateType = CoateType.Village, ParentId = 355,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2110, Name = "Ничке-Суу", Code = "41706242862080", CoateType = CoateType.Village,
                    ParentId = 355, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2111, Name = "Найман", Code = "41706242865010", CoateType = CoateType.Village, ParentId = 356,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2112, Name = "Кек-Арт", Code = "41706246804010", CoateType = CoateType.Village, ParentId = 313,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2113, Name = "Кан-Коргон", Code = "41706246804020", CoateType = CoateType.Village,
                    ParentId = 313, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2114, Name = "Сайталаа", Code = "41706246804030", CoateType = CoateType.Village,
                    ParentId = 313, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2115, Name = "Сары-Бээ", Code = "41706246812010", CoateType = CoateType.Village,
                    ParentId = 314, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2116, Name = "Кара-Таш", Code = "41706246812020", CoateType = CoateType.Village,
                    ParentId = 314, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2117, Name = "Терек-Суу", Code = "41706246812030", CoateType = CoateType.Village,
                    ParentId = 314, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2118, Name = "Ничке-Суу", Code = "41706246812040", CoateType = CoateType.Village,
                    ParentId = 314, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2119, Name = "Кенеш", Code = "41706246815010", CoateType = CoateType.Village, ParentId = 315,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2120, Name = "Пор", Code = "41706246815020", CoateType = CoateType.Village, ParentId = 315,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2121, Name = "Джаны-Талаа", Code = "41706246816010", CoateType = CoateType.Village,
                    ParentId = 316, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2122, Name = "Алтын-Кюрек", Code = "41706246816020", CoateType = CoateType.Village,
                    ParentId = 316, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2123, Name = "Джетим-Дебе", Code = "41706246816030", CoateType = CoateType.Village,
                    ParentId = 316, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2124, Name = "Калматай", Code = "41706246816040", CoateType = CoateType.Village,
                    ParentId = 316, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2125, Name = "Кара-Джыгач", Code = "41706246816050", CoateType = CoateType.Village,
                    ParentId = 316, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2126, Name = "Насирдин", Code = "41706246816070", CoateType = CoateType.Village,
                    ParentId = 316, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2127, Name = "Кара-Кочкор", Code = "41706246818010", CoateType = CoateType.Village,
                    ParentId = 317, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2128, Name = "Ак-Кыя", Code = "41706246818020", CoateType = CoateType.Village, ParentId = 317,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2129, Name = "Кашка-Джол", Code = "41706246818050", CoateType = CoateType.Village,
                    ParentId = 317, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2130, Name = "Сары-Булак", Code = "41706246818070", CoateType = CoateType.Village,
                    ParentId = 317, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2131, Name = "Кара-Кульджа", Code = "41706246820010", CoateType = CoateType.Village,
                    ParentId = 318, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2132, Name = "Бий-Мырза", Code = "41706246820020", CoateType = CoateType.Village,
                    ParentId = 318, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2133, Name = "Первое  Мая", Code = "41706246820030", CoateType = CoateType.Village,
                    ParentId = 318, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2134, Name = "Сары-Камыш", Code = "41706246820040", CoateType = CoateType.Village,
                    ParentId = 318, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2135, Name = "Кызыл-Джар", Code = "41706246826010", CoateType = CoateType.Village,
                    ParentId = 319, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2136, Name = "Кайын-Талаа", Code = "41706246826020", CoateType = CoateType.Village,
                    ParentId = 319, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2137, Name = "Коо-Чаты", Code = "41706246826030", CoateType = CoateType.Village,
                    ParentId = 319, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2138, Name = "Терек", Code = "41706246826040", CoateType = CoateType.Village, ParentId = 319,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2139, Name = "Чычырканак", Code = "41706246826050", CoateType = CoateType.Village,
                    ParentId = 319, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2140, Name = "Куйоташ", Code = "41706246826060", CoateType = CoateType.Village, ParentId = 319,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2141, Name = "Ылай-Талаа", Code = "41706246834010", CoateType = CoateType.Village,
                    ParentId = 320, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2142, Name = "Сай", Code = "41706246834020", CoateType = CoateType.Village, ParentId = 320,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2143, Name = "Шаркыратма", Code = "41706246834030", CoateType = CoateType.Village,
                    ParentId = 320, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2144, Name = "Жылкол", Code = "41706246834040", CoateType = CoateType.Village, ParentId = 320,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2145, Name = "Сары-Таш", Code = "41706246834050", CoateType = CoateType.Village,
                    ParentId = 320, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2146, Name = "Ой-Тал", Code = "41706246838010", CoateType = CoateType.Village, ParentId = 321,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2147, Name = "Кондук", Code = "41706246838020", CoateType = CoateType.Village, ParentId = 321,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2148, Name = "Сары-Булак", Code = "41706246849010", CoateType = CoateType.Village,
                    ParentId = 322, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2149, Name = "Кара-Булак", Code = "41706246849020", CoateType = CoateType.Village,
                    ParentId = 322, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2150, Name = "Конокбай-Талаа", Code = "41706246849030", CoateType = CoateType.Village,
                    ParentId = 322, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2151, Name = "Кызыл-Булак", Code = "41706246849040", CoateType = CoateType.Village,
                    ParentId = 322, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2152, Name = "Сары-Кюнгей", Code = "41706246849050", CoateType = CoateType.Village,
                    ParentId = 322, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2153, Name = "Тегерек-Саз", Code = "41706246849060", CoateType = CoateType.Village,
                    ParentId = 322, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2154, Name = "Тогуз-Булак", Code = "41706246849070", CoateType = CoateType.Village,
                    ParentId = 322, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2155, Name = "Токбай-Талаа", Code = "41706246860010", CoateType = CoateType.Village,
                    ParentId = 323, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2156, Name = "Буйга   ", Code = "41706246860020", CoateType = CoateType.Village,
                    ParentId = 323, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2157, Name = "Джаны-Талап", Code = "41706246861010", CoateType = CoateType.Village,
                    ParentId = 324, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2158, Name = "Жийде", Code = "41706246861020", CoateType = CoateType.Village, ParentId = 324,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2159, Name = "Октябрь", Code = "41706246861030", CoateType = CoateType.Village, ParentId = 324,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2160, Name = "Тоготой", Code = "41706246861040", CoateType = CoateType.Village, ParentId = 324,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2161, Name = "Ынтымак", Code = "41706246861050", CoateType = CoateType.Village, ParentId = 324,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2162, Name = "Ак-Джар", Code = "41706255804010", CoateType = CoateType.Village, ParentId = 357,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2163, Name = "Какыр", Code = "41706255804020", CoateType = CoateType.Village, ParentId = 357,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2164, Name = "Семиз-Кель", Code = "41706255804080", CoateType = CoateType.Village,
                    ParentId = 357, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2165, Name = "Большевик", Code = "41706255804090", CoateType = CoateType.Village,
                    ParentId = 357, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2166, Name = "Кенеш", Code = "41706255808010", CoateType = CoateType.Village, ParentId = 358,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2167, Name = "Джаны-Джол", Code = "41706255808020", CoateType = CoateType.Village,
                    ParentId = 358, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2168, Name = "Кош-Коргон", Code = "41706255808030", CoateType = CoateType.Village,
                    ParentId = 358, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2169, Name = "Кызыл-Кырман", Code = "41706255808040", CoateType = CoateType.Village,
                    ParentId = 358, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2170, Name = "Курбу-Таш", Code = "41706255813010", CoateType = CoateType.Village,
                    ParentId = 359, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2171, Name = "Ак-Терек", Code = "41706255813020", CoateType = CoateType.Village,
                    ParentId = 359, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2172, Name = "Им. Карла Маркса", Code = "41706255813030", CoateType = CoateType.Village,
                    ParentId = 359, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2173, Name = "Им. Кирова", Code = "41706255813040", CoateType = CoateType.Village,
                    ParentId = 359, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2174, Name = "Кысык-Алма", Code = "41706255813050", CoateType = CoateType.Village,
                    ParentId = 359, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2175, Name = "Туз-Бель", Code = "41706255813060", CoateType = CoateType.Village,
                    ParentId = 359, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2176, Name = "Учкаптал", Code = "41706255813070", CoateType = CoateType.Village,
                    ParentId = 359, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2177, Name = "Кара-Тарык", Code = "41706255813080", CoateType = CoateType.Village,
                    ParentId = 359, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2178, Name = "Джыланды", Code = "41706255815010", CoateType = CoateType.Village,
                    ParentId = 360, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2179, Name = "Калта", Code = "41706255815020", CoateType = CoateType.Village, ParentId = 360,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2180, Name = "Красный Маяк", Code = "41706255815030", CoateType = CoateType.Village,
                    ParentId = 360, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2181, Name = "Прогресс", Code = "41706255815040", CoateType = CoateType.Village,
                    ParentId = 360, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2182, Name = "Яссы", Code = "41706255815050", CoateType = CoateType.Village, ParentId = 360,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2183, Name = "Ботомойнок", Code = "41706255815060", CoateType = CoateType.Village,
                    ParentId = 360, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2184, Name = "Бакмал", Code = "41706255817010", CoateType = CoateType.Village, ParentId = 361,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2185, Name = "Бабашуулу", Code = "41706255817020", CoateType = CoateType.Village,
                    ParentId = 361, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2186, Name = "Бексе-Джол", Code = "41706255817030", CoateType = CoateType.Village,
                    ParentId = 361, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2187, Name = "Джаны-Абад", Code = "41706255817040", CoateType = CoateType.Village,
                    ParentId = 361, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2188, Name = "Ден-Булак", Code = "41706255817050", CoateType = CoateType.Village,
                    ParentId = 361, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2189, Name = "Кара-Дарыя", Code = "41706255817060", CoateType = CoateType.Village,
                    ParentId = 361, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2190, Name = "Мичурино", Code = "41706255817070", CoateType = CoateType.Village,
                    ParentId = 361, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2191, Name = "Озгерюш", Code = "41706255817080", CoateType = CoateType.Village, ParentId = 361,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2192, Name = "Теолес", Code = "41706255817090", CoateType = CoateType.Village, ParentId = 361,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2193, Name = "Чимбай", Code = "41706255817100", CoateType = CoateType.Village, ParentId = 361,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2194, Name = "Тосой", Code = "41706255822010", CoateType = CoateType.Village, ParentId = 362,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2195, Name = "Аюу", Code = "41706255822020", CoateType = CoateType.Village, ParentId = 362,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2196, Name = "Джаны-Айыл", Code = "41706255822030", CoateType = CoateType.Village,
                    ParentId = 362, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2197, Name = "Заргер", Code = "41706255822040", CoateType = CoateType.Village, ParentId = 362,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2198, Name = "Кайрат", Code = "41706255822050", CoateType = CoateType.Village, ParentId = 362,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2199, Name = "Кутурган", Code = "41706255822060", CoateType = CoateType.Village,
                    ParentId = 362, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2200, Name = "Ничке-Сай", Code = "41706255822070", CoateType = CoateType.Village,
                    ParentId = 362, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2201, Name = "Токтогул", Code = "41706255822080", CoateType = CoateType.Village,
                    ParentId = 362, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2202, Name = "Кара-Дыйкан", Code = "41706255824010", CoateType = CoateType.Village,
                    ParentId = 363, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2203, Name = "Кызыл-Дыйкан", Code = "41706255824020", CoateType = CoateType.Village,
                    ParentId = 363, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2204, Name = "Жээренчи", Code = "41706255824030", CoateType = CoateType.Village,
                    ParentId = 363, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2205, Name = "Жазы", Code = "41706255824040", CoateType = CoateType.Village, ParentId = 363,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2206, Name = "Джийде", Code = "41706255826010", CoateType = CoateType.Village, ParentId = 364,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2207, Name = "Ак-Терек", Code = "41706255826020", CoateType = CoateType.Village,
                    ParentId = 364, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2208, Name = "Джангакты", Code = "41706255826030", CoateType = CoateType.Village,
                    ParentId = 364, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2209, Name = "Кара-Колот", Code = "41706255826040", CoateType = CoateType.Village,
                    ParentId = 364, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2210, Name = "Корс-Этти", Code = "41706255826050", CoateType = CoateType.Village,
                    ParentId = 364, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2211, Name = "Кыргызстан", Code = "41706255826060", CoateType = CoateType.Village,
                    ParentId = 364, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2212, Name = "Орказган", Code = "41706255826070", CoateType = CoateType.Village,
                    ParentId = 364, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2213, Name = "Чангет", Code = "41706255828010", CoateType = CoateType.Village, ParentId = 365,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2214, Name = "Остуруу", Code = "41706255828020", CoateType = CoateType.Village, ParentId = 365,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2215, Name = "Ийрек", Code = "41706255830010", CoateType = CoateType.Village, ParentId = 366,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2216, Name = "Коргон", Code = "41706255830020", CoateType = CoateType.Village, ParentId = 366,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2217, Name = "Ункюр", Code = "41706255830030", CoateType = CoateType.Village, ParentId = 366,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2218, Name = "Ынтымак", Code = "41706255830040", CoateType = CoateType.Village, ParentId = 366,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2219, Name = "Эльчибек", Code = "41706255830050", CoateType = CoateType.Village,
                    ParentId = 366, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2220, Name = "Кароол", Code = "41706255832010", CoateType = CoateType.Village, ParentId = 367,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2221, Name = "Джан-Шоро", Code = "41706255832020", CoateType = CoateType.Village,
                    ParentId = 367, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2222, Name = "Мырза-Арык", Code = "41706255832030", CoateType = CoateType.Village,
                    ParentId = 367, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2223, Name = "Орто-Арык", Code = "41706255832040", CoateType = CoateType.Village,
                    ParentId = 367, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2224, Name = "Шералы", Code = "41706255832050", CoateType = CoateType.Village, ParentId = 367,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2225, Name = "Шамал-Терек", Code = "41706255840020", CoateType = CoateType.Village,
                    ParentId = 368, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2226, Name = "Чалк-Ойде", Code = "41706255840070", CoateType = CoateType.Village,
                    ParentId = 368, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2227, Name = "Старая Покровка", Code = "41706255844010", CoateType = CoateType.Village,
                    ParentId = 369, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2228, Name = "Алга", Code = "41706255844020", CoateType = CoateType.Village, ParentId = 369,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2229, Name = "Беш-Абышка", Code = "41706255844030", CoateType = CoateType.Village,
                    ParentId = 369, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2230, Name = "Гузар", Code = "41706255844040", CoateType = CoateType.Village, ParentId = 369,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2231, Name = "Кочкор-Ата", Code = "41706255844050", CoateType = CoateType.Village,
                    ParentId = 369, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2232, Name = "Кремль", Code = "41706255844060", CoateType = CoateType.Village, ParentId = 369,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2233, Name = "Куршаб", Code = "41706255844070", CoateType = CoateType.Village, ParentId = 369,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2234, Name = "Кызыл-Октябрь", Code = "41706255844080", CoateType = CoateType.Village,
                    ParentId = 369, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2235, Name = "Кызыл-Сенгир", Code = "41706255844090", CoateType = CoateType.Village,
                    ParentId = 369, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2236, Name = "Кызыл-Тоо", Code = "41706255847010", CoateType = CoateType.Village,
                    ParentId = 370, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2237, Name = "Донуз-Тоо", Code = "41706255847020", CoateType = CoateType.Village,
                    ParentId = 370, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2238, Name = "Ак-Кыя", Code = "41706255847030", CoateType = CoateType.Village, ParentId = 370,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2239, Name = "Карчабек", Code = "41706255847040", CoateType = CoateType.Village,
                    ParentId = 370, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2240, Name = "Эркин-Тоо", Code = "41706255847050", CoateType = CoateType.Village,
                    ParentId = 370, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2241, Name = "Куршаб", Code = "41706255853010", CoateType = CoateType.Village, ParentId = 371,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2242, Name = "Эрдик", Code = "41706255853020", CoateType = CoateType.Village, ParentId = 371,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2243, Name = "Шагым", Code = "41706255853030", CoateType = CoateType.Village, ParentId = 371,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2244, Name = "Мырза-Аке", Code = "41706255859010", CoateType = CoateType.Village,
                    ParentId = 372, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2245, Name = "Адыр", Code = "41706255859020", CoateType = CoateType.Village, ParentId = 372,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2246, Name = "Бабыр", Code = "41706255859030", CoateType = CoateType.Village, ParentId = 372,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2247, Name = "Алтын-Булак", Code = "41706255860010", CoateType = CoateType.Village,
                    ParentId = 373, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2248, Name = "Чечебай", Code = "41706255860020", CoateType = CoateType.Village, ParentId = 373,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2249, Name = "Таш-Башат", Code = "41706255860030", CoateType = CoateType.Village,
                    ParentId = 373, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2250, Name = "Сасык-Булак", Code = "41706255860040", CoateType = CoateType.Village,
                    ParentId = 373, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2251, Name = "Кара-Баткак", Code = "41706255860050", CoateType = CoateType.Village,
                    ParentId = 373, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2252, Name = "Кандава", Code = "41706255860060", CoateType = CoateType.Village, ParentId = 373,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2253, Name = "Саламалик", Code = "41706255865010", CoateType = CoateType.Village,
                    ParentId = 374, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2254, Name = "Ак-Терек", Code = "41706255865020", CoateType = CoateType.Village,
                    ParentId = 374, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2255, Name = "Ара-Кель", Code = "41706255865030", CoateType = CoateType.Village,
                    ParentId = 374, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2256, Name = "Кош-Этер", Code = "41706255865040", CoateType = CoateType.Village,
                    ParentId = 374, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2257, Name = "Кызыл-Байрак", Code = "41706255865050", CoateType = CoateType.Village,
                    ParentId = 374, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2258, Name = "Кызыл-Чарба", Code = "41706255865060", CoateType = CoateType.Village,
                    ParentId = 374, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2259, Name = "15 Жаш", Code = "41706255865070", CoateType = CoateType.Village, ParentId = 374,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2260, Name = "Шоро-Башат", Code = "41706255876010", CoateType = CoateType.Village,
                    ParentId = 375, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2261, Name = "Ана-Кызыл", Code = "41706255876020", CoateType = CoateType.Village,
                    ParentId = 375, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2262, Name = "Бостон", Code = "41706255876030", CoateType = CoateType.Village, ParentId = 375,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2263, Name = "Кыймыл", Code = "41706255876040", CoateType = CoateType.Village, ParentId = 375,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2264, Name = "Макаренко", Code = "41706255876050", CoateType = CoateType.Village,
                    ParentId = 375, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2265, Name = "Карамык", Code = "41706259816010", CoateType = CoateType.Village, ParentId = 376,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2266, Name = "Жекенди", Code = "41706259816020", CoateType = CoateType.Village, ParentId = 376,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2267, Name = "Кара-Тейит", Code = "41706259816030", CoateType = CoateType.Village,
                    ParentId = 376, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2268, Name = "Шибээ", Code = "41706259816040", CoateType = CoateType.Village, ParentId = 376,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2269, Name = "Чулук", Code = "41706259816050", CoateType = CoateType.Village, ParentId = 376,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2270, Name = "Кашка-Суу", Code = "41706259824010", CoateType = CoateType.Village,
                    ParentId = 377, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2271, Name = "Ачык-Суу", Code = "41706259824020", CoateType = CoateType.Village,
                    ParentId = 377, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2272, Name = "Кабык", Code = "41706259824030", CoateType = CoateType.Village, ParentId = 377,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2273, Name = "Кара-Кабак", Code = "41706259824040", CoateType = CoateType.Village,
                    ParentId = 377, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2274, Name = "Бурган-Суу", Code = "41706259824050", CoateType = CoateType.Village,
                    ParentId = 377, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2275, Name = "Дароот-Коргон", Code = "41706259851010", CoateType = CoateType.Village,
                    ParentId = 378, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2276, Name = "Жар-Башы", Code = "41706259851020", CoateType = CoateType.Village,
                    ParentId = 378, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2277, Name = "Жаш-Тилек", Code = "41706259851030", CoateType = CoateType.Village,
                    ParentId = 378, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2278, Name = "Жаман-Жар", Code = "41706259851040", CoateType = CoateType.Village,
                    ParentId = 378, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2279, Name = "Кочкорчу", Code = "41706259851050", CoateType = CoateType.Village,
                    ParentId = 378, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2280, Name = "Кулчу", Code = "41706259851060", CoateType = CoateType.Village, ParentId = 378,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2281, Name = "Кызыл-Туу", Code = "41706259851070", CoateType = CoateType.Village,
                    ParentId = 378, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2282, Name = "Сары-Булак", Code = "41706259851080", CoateType = CoateType.Village,
                    ParentId = 378, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2283, Name = "Чак", Code = "41706259851090", CoateType = CoateType.Village, ParentId = 378,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2284, Name = "Кызыл-Эшме", Code = "41706259851100", CoateType = CoateType.Village,
                    ParentId = 378, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2285, Name = "Кара-Шыбак", Code = "41706259851110", CoateType = CoateType.Village,
                    ParentId = 378, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2286, Name = "Джоон-Дебе", Code = "41707215804010", CoateType = CoateType.Village,
                    ParentId = 388, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2287, Name = "Джийде", Code = "41707215804020", CoateType = CoateType.Village, ParentId = 388,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2288, Name = "Бейшеке", Code = "41707215805010", CoateType = CoateType.Village, ParentId = 389,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2289, Name = "Кара-Буура", Code = "41707215805030", CoateType = CoateType.Village,
                    ParentId = 389, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2290, Name = "Кара-Суу", Code = "41707215805040", CoateType = CoateType.Village,
                    ParentId = 389, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2291, Name = "Бакыян", Code = "41707215806010", CoateType = CoateType.Village, ParentId = 390,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2292, Name = "Тамчи-Булак", Code = "41707215806020", CoateType = CoateType.Village,
                    ParentId = 390, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2293, Name = "Аманбаево", Code = "41707215807010", CoateType = CoateType.Village,
                    ParentId = 391, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2294, Name = "Ак-Жар", Code = "41707215807020", CoateType = CoateType.Village, ParentId = 391,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2295, Name = "Куру-Маймак", Code = "41707215807030", CoateType = CoateType.Village,
                    ParentId = 391, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2296, Name = "Суулу-Маймак", Code = "41707215807040", CoateType = CoateType.Village,
                    ParentId = 391, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2297, Name = "Ак-Башат", Code = "41707215815010", CoateType = CoateType.Village,
                    ParentId = 392, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2298, Name = "Кара-Сай", Code = "41707215815020", CoateType = CoateType.Village,
                    ParentId = 392, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2299, Name = "Кызыл-Адыр", Code = "41707215818010", CoateType = CoateType.Village,
                    ParentId = 393, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2300, Name = "Чон-Кара-Буура", Code = "41707215818020", CoateType = CoateType.Village,
                    ParentId = 393, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2301, Name = "Уч-Булак", Code = "41707215818030", CoateType = CoateType.Village,
                    ParentId = 393, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2302, Name = "Кек-Сай", Code = "41707215821010", CoateType = CoateType.Village, ParentId = 394,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2303, Name = "Кайнар", Code = "41707215821020", CoateType = CoateType.Village, ParentId = 394,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2304, Name = "Чымгент", Code = "41707215840010", CoateType = CoateType.Village, ParentId = 395,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2305, Name = "Кек-Дебе", Code = "41707215840020", CoateType = CoateType.Village,
                    ParentId = 395, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2306, Name = "Шекер", Code = "41707215843010", CoateType = CoateType.Village, ParentId = 396,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2307, Name = "Арчагул", Code = "41707215843020", CoateType = CoateType.Village, ParentId = 396,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2308, Name = "Маймак", Code = "41707215846010", CoateType = CoateType.Village, ParentId = 397,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2309, Name = "Ынтымак", Code = "41707220808010", CoateType = CoateType.Village, ParentId = 379,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2310, Name = "Туйте", Code = "41707220808020", CoateType = CoateType.Village, ParentId = 379,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2311, Name = "Боо-Терек", Code = "41707220823010", CoateType = CoateType.Village,
                    ParentId = 380, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2312, Name = "Кызыл-Октябрь", Code = "41707220826010", CoateType = CoateType.Village,
                    ParentId = 381, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2313, Name = "Кек-Таш", Code = "41707220826020", CoateType = CoateType.Village, ParentId = 381,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2314, Name = "Маданият", Code = "41707220826030", CoateType = CoateType.Village,
                    ParentId = 381, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2315, Name = "Таш-Кудук", Code = "41707220826040", CoateType = CoateType.Village,
                    ParentId = 381, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2316, Name = "Урмарал", Code = "41707220826050", CoateType = CoateType.Village, ParentId = 381,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2317, Name = "Кен-Арал", Code = "41707220828010", CoateType = CoateType.Village,
                    ParentId = 382, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2318, Name = "Бакай-Ата", Code = "41707220830010", CoateType = CoateType.Village,
                    ParentId = 383, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2319, Name = "Наматбек", Code = "41707220830020", CoateType = CoateType.Village,
                    ParentId = 383, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2320, Name = "Мин-Булак", Code = "41707220833010", CoateType = CoateType.Village,
                    ParentId = 384, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2321, Name = "Озгерюш", Code = "41707220835010", CoateType = CoateType.Village, ParentId = 385,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2322, Name = "Ак-Дебе", Code = "41707220840010", CoateType = CoateType.Village, ParentId = 386,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2323, Name = "Кызыл-Сай", Code = "41707220840020", CoateType = CoateType.Village,
                    ParentId = 386, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2324, Name = "Кызыл-Чарба", Code = "41707220840030", CoateType = CoateType.Village,
                    ParentId = 386, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2325, Name = "Кыргызстан", Code = "41707220843010", CoateType = CoateType.Village,
                    ParentId = 387, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2326, Name = "Джон-Коргон", Code = "41707220843020", CoateType = CoateType.Village,
                    ParentId = 387, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2327, Name = "Первомайское", Code = "41707220843030", CoateType = CoateType.Village,
                    ParentId = 387, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2328, Name = "Арал", Code = "41707225818010", CoateType = CoateType.Village, ParentId = 398,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2329, Name = "Каинды", Code = "41707225818020", CoateType = CoateType.Village, ParentId = 398,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2330, Name = "Нылды", Code = "41707225818030", CoateType = CoateType.Village, ParentId = 398,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2331, Name = "Сары-Булак", Code = "41707225818040", CoateType = CoateType.Village,
                    ParentId = 398, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2332, Name = "Чеч-Дебе", Code = "41707225818050", CoateType = CoateType.Village,
                    ParentId = 398, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2333, Name = "Талас", Code = "41707225820010", CoateType = CoateType.Village, ParentId = 399,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2334, Name = "Кек-Дебе", Code = "41707225820020", CoateType = CoateType.Village,
                    ParentId = 399, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2335, Name = "Манас", Code = "41707225820030", CoateType = CoateType.Village, ParentId = 399,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2336, Name = "Майское", Code = "41707225826010", CoateType = CoateType.Village, ParentId = 400,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2337, Name = "Новодонецкое   ", Code = "41707225826020", CoateType = CoateType.Village,
                    ParentId = 400, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2338, Name = "Покровка", Code = "41707225833010", CoateType = CoateType.Village,
                    ParentId = 401, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2339, Name = "Баласары", Code = "41707225833020", CoateType = CoateType.Village,
                    ParentId = 401, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2340, Name = "Джайылган", Code = "41707225833030", CoateType = CoateType.Village,
                    ParentId = 401, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2341, Name = "Кара-Арча", Code = "41707225833040", CoateType = CoateType.Village,
                    ParentId = 401, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2342, Name = "Сегет", Code = "41707225833050", CoateType = CoateType.Village, ParentId = 401,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2343, Name = "Кызыл-Джылдыз", Code = "41707225845010", CoateType = CoateType.Village,
                    ParentId = 402, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2344, Name = "Ак-Таш", Code = "41707225845020", CoateType = CoateType.Village, ParentId = 402,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2345, Name = "Джийде", Code = "41707225845030", CoateType = CoateType.Village, ParentId = 402,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2346, Name = "Кенеш", Code = "41707225845040", CoateType = CoateType.Village, ParentId = 402,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2347, Name = "Чон-Капка", Code = "41707225845050", CoateType = CoateType.Village,
                    ParentId = 402, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2348, Name = "Таш-Башат", Code = "41707225845060", CoateType = CoateType.Village,
                    ParentId = 402, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2349, Name = "Уч-Коргон", Code = "41707225845070", CoateType = CoateType.Village,
                    ParentId = 402, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2350, Name = "Арал", Code = "41707232804010", CoateType = CoateType.Village, ParentId = 403,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2351, Name = "Кызыл-Туу", Code = "41707232810020", CoateType = CoateType.Village,
                    ParentId = 404, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2352, Name = "Чыйырчык", Code = "41707232810030", CoateType = CoateType.Village,
                    ParentId = 404, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2353, Name = "Кек-Кашат", Code = "41707232810040", CoateType = CoateType.Village,
                    ParentId = 404, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2354, Name = "Таш-Арык", Code = "41707232813010", CoateType = CoateType.Village,
                    ParentId = 405, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2355, Name = "Ак-Джар", Code = "41707232813020", CoateType = CoateType.Village, ParentId = 405,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2356, Name = "Орто-Арык", Code = "41707232813030", CoateType = CoateType.Village,
                    ParentId = 405, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2357, Name = "Кок-Ой", Code = "41707232820010", CoateType = CoateType.Village, ParentId = 406,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2358, Name = "Сасык-Булак", Code = "41707232825010", CoateType = CoateType.Village,
                    ParentId = 407, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2359, Name = "Кара-Ой", Code = "41707232825020", CoateType = CoateType.Village, ParentId = 407,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2360, Name = "Кенеш", Code = "41707232825030", CoateType = CoateType.Village, ParentId = 407,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2361, Name = "Чон-Токой", Code = "41707232825040", CoateType = CoateType.Village,
                    ParentId = 407, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2362, Name = "Кепюре-Базар", Code = "41707232829010", CoateType = CoateType.Village,
                    ParentId = 408, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2363, Name = "Джон-Арык", Code = "41707232832010", CoateType = CoateType.Village,
                    ParentId = 409, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2364, Name = "Кек-Токой", Code = "41707232832020", CoateType = CoateType.Village,
                    ParentId = 409, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2365, Name = "Кум-Арык", Code = "41707232843010", CoateType = CoateType.Village,
                    ParentId = 410, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2366, Name = "Козучак", Code = "41707232843020", CoateType = CoateType.Village, ParentId = 410,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2367, Name = "Арашан", Code = "41707232843030", CoateType = CoateType.Village, ParentId = 410,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2368, Name = "Талды-Булак", Code = "41707232847010", CoateType = CoateType.Village,
                    ParentId = 411, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2369, Name = "Ак-Коргон", Code = "41707232847020", CoateType = CoateType.Village,
                    ParentId = 411, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2370, Name = "Манас", Code = "41707232859010", CoateType = CoateType.Village, ParentId = 412,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2371, Name = "Чат-Базар", Code = "41707232859020", CoateType = CoateType.Village,
                    ParentId = 412, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2372, Name = "Уч-Эмчек", Code = "41707232860010", CoateType = CoateType.Village,
                    ParentId = 413, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2373, Name = "Кара-Суу", Code = "41707232861010", CoateType = CoateType.Village,
                    ParentId = 414, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2374, Name = "Калба", Code = "41707232862010", CoateType = CoateType.Village, ParentId = 415,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2375, Name = "Атая Огонбаева", Code = "41707232862020", CoateType = CoateType.Village,
                    ParentId = 415, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2376, Name = "Балбал", Code = "41707232862030", CoateType = CoateType.Village, ParentId = 415,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2377, Name = "город Ош", Code = "41700000000021", CoateType = CoateType.District, ParentId = 2,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2378, Name = "Кок-Жангак", Code = "41703220400010", CoateType = CoateType.District,
                    ParentId = 4, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2379, Name = "Чолпон-Ата", Code = "41702215600010", CoateType = CoateType.Countryside,
                    ParentId = 16, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2380, Name = "Пристань-Пржевальск", Code = "41702410520010", CoateType = CoateType.Countryside,
                    ParentId = 20, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2381, Name = "Орто-Токой", Code = "41702420510010", CoateType = CoateType.Countryside,
                    ParentId = 19, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2382, Name = "Кант", Code = "41708206600010", CoateType = CoateType.Countryside, ParentId = 58,
                    CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2383, Name = "Кара-Балта", Code = "41708209600010", CoateType = CoateType.Countryside,
                    ParentId = 59, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2384, Name = "Орловка", Code = "41708213600010", CoateType = CoateType.Countryside,
                    ParentId = 61, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2385, Name = "Кемин", Code = "41708213600020", CoateType = CoateType.Countryside,
                    ParentId = 61, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2386, Name = "Бордунский", Code = "41708213530020", CoateType = CoateType.Countryside,
                    ParentId = 61, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2387, Name = "Каинды", Code = "41708219600010", CoateType = CoateType.Countryside,
                    ParentId = 63, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2388, Name = "Шопоков", Code = "41708222600010", CoateType = CoateType.Countryside,
                    ParentId = 64, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2389, Name = "Чон-Арык", Code = "41711201510010", CoateType = CoateType.Countryside,
                    ParentId = 10, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2390, Name = "Орто-Сай", Code = "41711201800010", CoateType = CoateType.Countryside,
                    ParentId = 10, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2391, Name = "Булак-Башы", Code = "41705410800010", CoateType = CoateType.Countryside,
                    ParentId = 42, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2392, Name = "Кызыл-Жол", Code = "41705410800020", CoateType = CoateType.Countryside,
                    ParentId = 42, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2393, Name = "Базар-Башы", Code = "41705410800030", CoateType = CoateType.Countryside,
                    ParentId = 42, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2394, Name = "Восточный ", Code = "41705420510010", CoateType = CoateType.Countryside,
                    ParentId = 43, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2395, Name = "Караван", Code = "41705430800010", CoateType = CoateType.Countryside,
                    ParentId = 44, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2396, Name = "Ак-Булак", Code = "41705430800020", CoateType = CoateType.Countryside,
                    ParentId = 44, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2397, Name = "Джин-Джиген", Code = "41705430800030", CoateType = CoateType.Countryside,
                    ParentId = 44, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2398, Name = "Исфана", Code = "41705236610010", CoateType = CoateType.Countryside,
                    ParentId = 40, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2399, Name = "Голбо", Code = "41705236610810", CoateType = CoateType.Countryside,
                    ParentId = 40, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2400, Name = "Самат", Code = "41705236610820", CoateType = CoateType.Countryside,
                    ParentId = 40, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2401, Name = "Чимген", Code = "41705236610830", CoateType = CoateType.Countryside,
                    ParentId = 40, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2402, Name = "Тайлан", Code = "41705236610840", CoateType = CoateType.Countryside,
                    ParentId = 40, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2403, Name = "Мырза-Патча", Code = "41705236610850", CoateType = CoateType.Countryside,
                    ParentId = 40, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2404, Name = "Ак-Булак", Code = "41705236610860", CoateType = CoateType.Countryside,
                    ParentId = 40, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2405, Name = "Айдаркен", Code = "41705258600010", CoateType = CoateType.Countryside,
                    ParentId = 41, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2406, Name = "Кадамжай", Code = "41705258610020", CoateType = CoateType.Countryside,
                    ParentId = 41, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2407, Name = "Таш-Кыя", Code = "41705258610810", CoateType = CoateType.Countryside,
                    ParentId = 41, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2408, Name = "Пульгон", Code = "41705258610820", CoateType = CoateType.Countryside,
                    ParentId = 41, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2409, Name = "Чал-Таш", Code = "41705258610830", CoateType = CoateType.Countryside,
                    ParentId = 41, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2410, Name = "Кербен", Code = "41703211610010", CoateType = CoateType.Countryside,
                    ParentId = 23, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2411, Name = "Курулуш", Code = "41703211610810", CoateType = CoateType.Countryside,
                    ParentId = 23, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2412, Name = "Кулук-Добо", Code = "41703211610820", CoateType = CoateType.Countryside,
                    ParentId = 23, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2413, Name = "Ак-Добо", Code = "41703211610830", CoateType = CoateType.Countryside,
                    ParentId = 23, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2414, Name = "Жетиген", Code = "41703211610840", CoateType = CoateType.Countryside,
                    ParentId = 23, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2415, Name = "Мамай", Code = "41703211610850", CoateType = CoateType.Countryside,
                    ParentId = 23, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2416, Name = "Устукан", Code = "41703211610860", CoateType = CoateType.Countryside,
                    ParentId = 23, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2417, Name = "Кочкор-Ата", Code = "41703215600010", CoateType = CoateType.Countryside,
                    ParentId = 24, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2418, Name = "Токтогул", Code = "41703225600010", CoateType = CoateType.Countryside,
                    ParentId = 27, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2419, Name = "Качкынчы", Code = "41703410800010", CoateType = CoateType.Countryside,
                    ParentId = 29, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2420, Name = "Кельме", Code = "41703410800020", CoateType = CoateType.Countryside,
                    ParentId = 29, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2421, Name = "Кызыл-Кыргызстан", Code = "41703410800030", CoateType = CoateType.Countryside,
                    ParentId = 29, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2422, Name = "Кызыл-Суу", Code = "41703410800040", CoateType = CoateType.Countryside,
                    ParentId = 29, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2423, Name = "Таш-Кутчу", Code = "41703410800050", CoateType = CoateType.Countryside,
                    ParentId = 29, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2424, Name = "Им. Тельмана", Code = "41703410800060", CoateType = CoateType.Countryside,
                    ParentId = 29, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2425, Name = "Кызыл-Джар", Code = "41703420510010", CoateType = CoateType.Countryside,
                    ParentId = 30, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2426, Name = "Шамалды-Сай", Code = "41703420520010", CoateType = CoateType.Countryside,
                    ParentId = 30, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2427, Name = "Тендик", Code = "41703420800010", CoateType = CoateType.Countryside,
                    ParentId = 30, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2428, Name = "Кашкулак-Сай", Code = "41703420800020", CoateType = CoateType.Countryside,
                    ParentId = 30, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2429, Name = "Чуйут-Сай", Code = "41703420800030", CoateType = CoateType.Countryside,
                    ParentId = 30, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2430, Name = "Кызыл-Алма", Code = "41703420800040", CoateType = CoateType.Countryside,
                    ParentId = 30, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2431, Name = "Кудук-Сай", Code = "41703420800050", CoateType = CoateType.Countryside,
                    ParentId = 30, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2432, Name = "Кек – Таш", Code = "41703430510010", CoateType = CoateType.Countryside,
                    ParentId = 31, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2433, Name = "Сары-Бээ", Code = "41703430710010", CoateType = CoateType.Countryside,
                    ParentId = 31, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2434, Name = "Когой", Code = "41703430710020", CoateType = CoateType.Countryside,
                    ParentId = 31, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2435, Name = "Кара-Жыгач", Code = "41703430710030", CoateType = CoateType.Countryside,
                    ParentId = 31, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2436, Name = "Кетмен-Тебе", Code = "41703440510010", CoateType = CoateType.Countryside,
                    ParentId = 32, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2437, Name = "Жазы-Кечу", Code = "41703440800010", CoateType = CoateType.Countryside,
                    ParentId = 32, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2438, Name = "Кара-Суу", Code = "41706226600010", CoateType = CoateType.Countryside,
                    ParentId = 47, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2439, Name = "Ноокат", Code = "41706242600010", CoateType = CoateType.Countryside,
                    ParentId = 48, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2440, Name = "Узген", Code = "41706255600010", CoateType = CoateType.Countryside,
                    ParentId = 50, CreatedBy = 1, Created = _initialDate
                },
                new CoateRecord
                {
                    Id = 2441, Name = "Кольцо", Code = "41705420800010", CoateType = CoateType.Countryside,
                    ParentId = 43, CreatedBy = 1, Created = _initialDate
                },
            };

            builder.Entity<CoateRecord>().HasData(coateRecords);

            return builder;
        }
    }
}