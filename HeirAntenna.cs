namespace Levels
{
    //Класс второго уровня
    public class HeirAntenna : ParentAntenna //Наследование от первого класса
    {
        //Перечисление для удобного хранения типа
        enum Type
        {
            Azimuthal,//=0
            Polar,    //=1
            Thoroidal //=2
        }
        //Хранение типа
        private Type type;

        public HeirAntenna(double diameter, string material, double cost, int type) 
        //Вызов конструктора родителя
            : base(diameter, material, cost)
        {
            //Приведение индекса из списка к перечислению
            this.type = (Type)type;
        }
        //Перегруженный метод оценки качества
        public override double Quality()
        {
            var q = base.Quality(); //Вызов метода оценки качества родителя
            if (type == Type.Azimuthal)
            {
                return q;
            }
            else if (type == Type.Polar)
            {
                return q * 2;
            }
            else
            {
                return q * 2.5;
            }
        }
        //Перегруженный метод вывода информации
        public override string GetInfo()
        {
            string info = base.GetInfo(); //Вызов метода вывода информации родителя
            info += "Тип: ";
            if (type == Type.Azimuthal)
            {
                info += "Азимутальная\n";
            }
            else if (type == Type.Polar)
            {
                info += "Полярная\n";
            }
            else if (type == Type.Thoroidal)
            {
                info += "Тороидальная\n";
            }

            return info;
        }
    }
}
