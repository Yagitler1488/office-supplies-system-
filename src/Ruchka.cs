class Ручка : КанцТовары
{
    public Ручка(string М, int Ц, int К, int П, int О, int Р, Цвета_Письма ЦП)
        : base(М, Ц, К, П, О, Р)
    {
        Цвет_Письма = ЦП;
    }
    
    public Цвета_Письма Цвет_Письма;
    
    public enum Цвета_Письма
    {
        Красный,
        Синий,
        Черный,
        Зеленый
    }
    
    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Цвет Письма: {Цвет_Письма}");
    }
}
