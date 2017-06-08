using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace ATH_kino
{
    public class AthQuery
    {
        public ATH_kinoEntities Ctx = new ATH_kinoEntities();
        public List<string> FilmTitlesList { get; set; } = new List<string>();
        public string CurrentFilmTitle { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Country { get; set; }
        public DateTime Premiere { get; set; }
        public string Genre { get; set; }
        public string Actor { get; set; }
        public Bitmap Cover { get; set; }
        public List<DateTime> CurrentFilmDateList { get; set; } = new List<DateTime>();
        public DateTime CurrentFilmCurrentDate { get; set; }
        public List<TimeSpan> CurrentFilmTimeList { get; set; } = new List<TimeSpan>();
        public TimeSpan CurrentFilmCurrentTime { get; set; }
        public int RoomNumber { get; set; }
        public int ShowtimeId { get; set; }
        public List<int> ShowtimeSeatList { get; set; } = new List<int>();

        public void GetFilmsTitles()
        {
            foreach (var film in Ctx.Film)
                FilmTitlesList.Add(film.Nazwa);
        }

        public void GetCurrentFilmDetails()
        {
            var filmInfo = (from f in Ctx.Film
                            join d in Ctx.Rezyser on f.ID_Rezyser equals d.ID_Rezyser
                            join w in Ctx.Scenarzysta on f.ID_Scenarzysta equals w.ID_Scenarzysta
                            join c in Ctx.Okladka on f.ID_Film equals c.ID_Film
                            where f.Nazwa == CurrentFilmTitle
                            select new
                            {
                                FilmName = f.Nazwa,
                                Director = d.Imie + " " + d.Nazwisko,
                                Writer = w.Imie + " " + w.Nazwisko,
                                Country = f.Produkcja,
                                Premiere = f.DataPremierySwiat,
                                Cover = c.Obraz
                            }).FirstOrDefault();

            var genreInfo = (from f in Ctx.Film
                             join gd in Ctx.GatunekSzczegoly on f.ID_Film equals gd.ID_Film
                             join g in Ctx.Gatunek on gd.ID_Gatunek equals g.ID_Gatunek
                             where f.Nazwa == CurrentFilmTitle
                             select new
                             {
                                 GenreName = g.Nazwa
                             }).ToList();

            var actorInfo = (from f in Ctx.Film
                             join r in Ctx.Rola on f.ID_Film equals r.ID_Film
                             join a in Ctx.Aktor on r.ID_Aktor equals a.ID_Aktor
                             where f.Nazwa == CurrentFilmTitle
                             select new
                             {
                                 ActorName = a.Imie + " " + a.Nazwisko,
                                 ActorRole = r.Nazwa
                             }).ToList();

            Director = filmInfo.Director;
            Writer = filmInfo.Writer;
            Country = filmInfo.Country;
            Premiere = filmInfo.Premiere;

            using (MemoryStream stream = new MemoryStream(filmInfo.Cover))
            {
                Cover = new Bitmap(stream);
            }

            Genre = string.Empty;
            foreach (var name in genreInfo)
                Genre += $"{name.GenreName}" + ", ";
            Genre = Genre.TrimEnd().TrimEnd(',');

            Actor = string.Empty;
            foreach (var name in actorInfo)
                Actor += $"{name.ActorName}" + "\n";
        }

        public void GetCurrentFilmDate()
        {
            CurrentFilmDateList.Clear();

            var dateInfo = (from f in Ctx.Film
                            join s in Ctx.Seans on f.ID_Film equals s.ID_Film
                            where f.Nazwa == CurrentFilmTitle
                            select s.Data);

            foreach (var date in dateInfo)
                if (!CurrentFilmDateList.Contains(date))
                    CurrentFilmDateList.Add(date);
        }

        public void GetCurrentFilmTime()
        {
            CurrentFilmTimeList.Clear();

            var timeInfo = (from f in Ctx.Film
                            join s in Ctx.Seans on f.ID_Film equals s.ID_Film
                            where (f.Nazwa == CurrentFilmTitle &&
                                   s.Data == CurrentFilmCurrentDate)
                            select s.Godzina);

            foreach (var time in timeInfo)
                CurrentFilmTimeList.Add(time);
        }

        public void GetCurrentShowtimeDetails()
        {

            var roomInfo = (from f in Ctx.Film
                            join s in Ctx.Seans on f.ID_Film equals s.ID_Film
                            join r in Ctx.Sala on s.ID_Sala equals r.ID_Sala
                            where (f.Nazwa == CurrentFilmTitle &&
                                   s.Data == CurrentFilmCurrentDate &&
                                   s.Godzina == CurrentFilmCurrentTime)
                            select new
                            {
                                roomNumber = s.ID_Sala,
                            }).FirstOrDefault();

            var showtimeInfo = (from f in Ctx.Film
                                join s in Ctx.Seans on f.ID_Film equals s.ID_Film
                                join re in Ctx.Rezerwacja on s.ID_Seans equals re.ID_Seans
                                where (f.Nazwa == CurrentFilmTitle &&
                                       s.Data == CurrentFilmCurrentDate &&
                                       s.Godzina == CurrentFilmCurrentTime)
                                select s.ID_Seans);

            var seatInfo = (from f in Ctx.Film
                            join s in Ctx.Seans on f.ID_Film equals s.ID_Film
                            join re in Ctx.Rezerwacja on s.ID_Seans equals re.ID_Seans
                            where (f.Nazwa == CurrentFilmTitle &&
                                   s.Data == CurrentFilmCurrentDate &&
                                   s.Godzina == CurrentFilmCurrentTime)
                            select re.Miejsce);

            foreach (var id in showtimeInfo)
                ShowtimeId = id;

            RoomNumber = roomInfo.roomNumber;

            ShowtimeSeatList.Clear();
            foreach (var seat in seatInfo)
                ShowtimeSeatList.Add(seat);




        }
    }
}