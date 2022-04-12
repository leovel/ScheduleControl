using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ScheduleControl.Models
{
    public class Holiday
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public bool Bridge { get; set; }

        private static readonly CultureInfo portuguesse = new CultureInfo("pt");
        public string DayStr => portuguesse.DateTimeFormat.GetDayName(Date.DayOfWeek);

        public static IEnumerable<Holiday> Holidays(int year, bool addBridges = false)
        {
            var result = new List<Holiday>
            {
                new Holiday
                {
                    Date = new DateTime(year,1,1),
                    Description = "Dia do Ano Novo"
                },
                new Holiday
                {
                    Date = new DateTime(year,2,4),
                    Description = "Dia do Início da Luta Armada de Libertação Nacional"
                },
                new Holiday
                {
                    Date = new DateTime(year,3,8),
                    Description = "Dia Internacional da Mulher"
                },
                new Holiday
                {
                    Date = new DateTime(year,3,23),
                    Description = "Dia da Libertação da África Austral"
                },
                new Holiday
                {
                    Date = new DateTime(year,4,4),
                    Description = "Dia da Paz e da Reconciliação Nacional"
                },
                new Holiday
                {
                    Date = new DateTime(year,5,1),
                    Description = "Dia Internacional do Trabalhador"
                },
                new Holiday
                {
                    Date = new DateTime(year,9,17),
                    Description = "Dia do Fundador da Nação e do Herói Nacional"
                },
                new Holiday
                {
                    Date = new DateTime(year,11,2),
                    Description = "Dia dos Finados"
                },
                new Holiday
                {
                    Date = new DateTime(year,11,11),
                    Description = "Dia da Independência"
                },
                new Holiday
                {
                    Date = new DateTime(year,12,25),
                    Description = "Dia de Natal e da Família"
                },
            };

            var (carnaval, sextasanta, pascoa, ccristi) = NonStaticHolidays(year);

            result.Add(new Holiday()
            {
                Date = carnaval,
                Description = "Dia do Carnaval"
            });

            result.Add(new Holiday()
            {
                Date = sextasanta,
                Description = "Sexta-Feira Santa"
            });

            if(addBridges)
            {
                AddBridges(result);
            }

            return result.OrderBy(h => h.Date);
        }

        private static void AddBridges(List<Holiday> holidays)
        {
            var dates = new HashSet<DateTime>();

            foreach (var holiday in holidays)
            {
                switch (holiday.Date.DayOfWeek)
                {
                    case DayOfWeek.Tuesday:
                        dates.Add(holiday.Date.AddDays(-1));
                        break;
                    case DayOfWeek.Thursday:
                        dates.Add(holiday.Date.AddDays(1));
                        break;
                    default:
                        break;
                }
            }

            holidays.AddRange(dates.Select(d => new Holiday { Date = d, Description = "Ponte (Prolongado)", Bridge = true }));

        }

        public static IEnumerable<TemporaryWeekDayRange> GetTemporariesFromBridges(IEnumerable<Holiday> holidays, Shift baseShift, int onDutyDelta = 0, int offDutyDelta = 90)
        {
            var alternativeShift = baseShift.DeltaTimeDeepClone(onDutyDelta, offDutyDelta);

            var temporaries = new List<TemporaryWeekDayRange>();
            foreach (var bridge in holidays.Where(h => h.Bridge))
            {
                switch (bridge.Date.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        temporaries.Add( new TemporaryWeekDayRange
                        {
                            Description = "Antecedência a Ponte (+1h30)",
                            AlternativeShift = alternativeShift,
                            From = bridge.Date.AddDays(-7),
                            To = bridge.Date.AddDays(-3),
                            Active = true
                        });
                        break;
                    case DayOfWeek.Friday:
                        temporaries.Add(new TemporaryWeekDayRange
                        {
                            Description = "Antecedência a Ponte (+1h30)",
                            AlternativeShift = alternativeShift,
                            From = bridge.Date.AddDays(-11),
                            To = bridge.Date.AddDays(-7),
                            Active = true
                        });
                        break;
                    default:
                        break;
                }
            }

            return temporaries.OrderBy(t => t.From);
        }

        private static (DateTime carnaval, DateTime sextasanta, DateTime pascoa, DateTime ccristi) NonStaticHolidays(int year)
        {
            int nRest = (year % 19) + 1;
            var day = new DateTime();
            switch (nRest)
            {
                case 1: day = new DateTime(year, 4, 14); break;
                case 2: day = new DateTime(year, 4, 3); break;
                case 3: day = new DateTime(year, 3, 23); break;
                case 4: day = new DateTime(year, 4, 11); break;
                case 5: day = new DateTime(year, 3, 31); break;
                case 6: day = new DateTime(year, 4, 18); break;
                case 7: day = new DateTime(year, 4, 8); break;
                case 8: day = new DateTime(year, 3, 28); break;
                case 9: day = new DateTime(year, 4, 16); break;
                case 10: day = new DateTime(year, 4, 5); break;
                case 11: day = new DateTime(year, 3, 25); break;
                case 12: day = new DateTime(year, 4, 13); break;
                case 13: day = new DateTime(year, 4, 2); break;
                case 14: day = new DateTime(year, 3, 22); break;
                case 15: day = new DateTime(year, 4, 10); break;
                case 16: day = new DateTime(year, 3, 30); break;
                case 17: day = new DateTime(year, 4, 17); break;
                case 18: day = new DateTime(year, 4, 7); break;
                case 19: day = new DateTime(year, 3, 27); break;
            }
            do
            {
                day = day.AddDays(1);
            }
            while (day.DayOfWeek != DayOfWeek.Sunday);
            return (day.AddDays(-47), day.AddDays(-2), day, day.AddDays(60));
        }

    }
}
