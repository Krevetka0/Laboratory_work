using System.Collections.Generic;
using System.Linq;
using DataTier;

namespace LogicTier
{
    public class БилетнаяПозиция
    {
        private Билет _билет;

        public БилетнаяПозиция(Билет p)
        { 
            _билет = p;
        }
        public string Транспорт
        {
            get { return _билет.Транспорт; }
            set { _билет.Транспорт = value; }
        }
        public string ПунктНазначения
        {
            get { return _билет.Пункт_назначения; }
            set { _билет.Пункт_назначения = value; }
        }
        public float ЦенаБилета
        {
            get { return _билет.Цена; }
            set { _билет.Цена = value; }
        }
        public string ПунктОтправки
        {
            get { return _билет.Пункт_отправки; }
            set { _билет.Пункт_отправки = value; }
        }

        public string ПредставлениеТовара
        {
            get 
            {
                return _билет.Пункт_отправки + " - " + _билет.Пункт_назначения;
            }
        }

        public int КоличествоАвтоРейсов
        {
            get { return _билет.КолВоБилетовНаАвтобус; }
            set { _билет.КолВоБилетовНаАвтобус = value; }
        }
    }

    public class Касса
    {
        private List<БилетнаяПозиция> _билеты = new List<БилетнаяПозиция>();
        public Касса()
        {
            List<Билет> tmp = ВсеБилеты.ПолучитьВсеБилеты();
            foreach (var t in tmp)
            {
                _билеты.Add(new БилетнаяПозиция(t));
            }
        }
        public List<БилетнаяПозиция> СписокБилетов
        {
            get { return _билеты; }
        }
        public string НаименованиеМагазина
        {
            get { return "Вокзал"; }
        }
    }
}
