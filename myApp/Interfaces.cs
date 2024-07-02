// interface is an abstract class
namespace datatypes{

    // interfaces dont have the return type, access modifier nor body
public interface IShape{
    double CalculateArea();
}
public interface IColor{
    string Color {get; set;}
}


// multiple inheritance
// interface is also used fo the security reasons
public class Rectangle: IShape, IColor{

    public double CalculateArea(){
        return 0;
    }

    public string Color {get; set;}
}

}
