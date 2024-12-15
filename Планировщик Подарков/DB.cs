using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace Планировщик_Подарков
{

    public class DB
    {
        List<Human> humans;

        List<Holidays> holidays;
        List<Gifts> gifts;

        public DB()
        {
            humans = new();
            gifts = new();
            holidays = new();
        }

        static DB instance;

        public static DB Instance
        {
            get
            {
                if (instance == null)
                    instance = new DB();
                return instance;
            }
        }
        public List<Human> Search(string search)
        {
            return humans.Where(s => s.FirstName.Contains(search) ||
            s.LastName.Contains(search) ||
            s.PatronymicName.Contains(search) != null).ToList();
        }






        //Удалить
        public void RemoveHuman(Human human)
        {
            humans.Remove(human);
        }
        public void RemoveGift(Gifts gift) {
            gifts.Remove(gift);
        }
        public void RemoveHoliday(Holidays holiday)
        {
            holidays.Remove(holiday);
        }
        //Добавить
        public void AddHuman(Human human)
        {
            humans.Add(human);
        }
        public void AddGift(Gifts gift)
        {
            gifts.Add(gift);
        }
        public void AddHoliday(Holidays holiday)
        {
            holidays.Add(holiday);
        }
        //


        public void Save(Human human)
        {
            using (var fs = File.Create("humans.json"))
            {
                JsonSerializer.Serialize(fs, human);
            }
        }
        public void Load(Human human)
        {
            using (var fs = File.OpenRead("humans.json"))
            {
                //human = (List<Human>)JsonSerializer.Deserialize(fs);
            }
        }


    }

}
