// See https://aka.ms/new-console-template for more information

using RecordsEqualityPractice;
using System;
using System.Collections;

WeatherData w = new WeatherData(1m, 1);
WeatherData e = new WeatherData(1m, 1);
Console.WriteLine(w.Equals(e));
Console.WriteLine(w==e);

Give a = new Give(1,2);
Give b = new Give(1,2);
Console.WriteLine(a.Equals(b));
Console.WriteLine(a==b);

Console.WriteLine(new string(new char[] {'a','b','c','d'},1,3));
Console.WriteLine(new string('=',10));

RecordWithClassProperty rp = new RecordWithClassProperty(0, new Person());
RecordWithClassProperty rp2 = new RecordWithClassProperty(0, new Person());
Console.WriteLine(rp.Equals(rp2));

RecordWithClassProperty rp3 = new RecordWithClassProperty(1, new Person() { Age = 1, Name="Asli" });
RecordWithClassProperty rp4 = new RecordWithClassProperty(1, new Person { Age = 1, Name="Asli" });
Console.WriteLine(rp3.ID);
Console.WriteLine(rp3.Equals(rp4));

Console.WriteLine(new string('=', 10));
Console.WriteLine("Class Practice");
Console.WriteLine();

//Parent par = new Parent();
Child chill = new Child(3, 4); // Properties inherited from the parent is initialized to default values.
                               // This, also, runs the default constructor of the parent class.
                               // If the parent class does not have a default constructor, this will give
                               // a compile time error.
Console.WriteLine("Child's name is  {0} and child's age is {1}", chill.Name, chill.Age);

public record WeatherData(decimal temperature, int humidity); // These are readonly.
public record RecordWithClassProperty(int ID, Person Person);
// public record RecordWithClassProperty(int ID, Person Person) : RecordWithClassProperty2;
// Id and Person is not read in this case. They are assigned the default values. Null for Person.

public record RecordWithClassProperty3 : RecordWithClassProperty2
{
    public RecordWithClassProperty3(int id, Person person) : base(id, person)
    {

    }

    public RecordWithClassProperty3() { }
}
public record RecordWithClassProperty2
{
    public int ID { get; set; }
    public Person? Person { get; set; }
    public RecordWithClassProperty2()
    {

    }

    public RecordWithClassProperty2(int id, Person person)
    {
        ID = id;
        Person = person;
    }
}

public record OpenRecord
{
    public OpenRecord()
    {

    }
}

public class Person
{
    public int Age { get; set; }
    public string? Name { get; set; }
}
public class Give : IEquatable<Give?>
{
    public decimal? Value { get; set; }
    public int? Tarik { get; set; }
    public Give(decimal? value, int? tarik)
    {
        Value = value;
        Tarik = tarik;
    }
    public override bool Equals(object? obj)
    {
        return Equals(obj as Give);
    }

    public bool Equals(Give? other)
    {
        return other is not null &&
               Value == other.Value &&
               Tarik == other.Tarik;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Value, Tarik);
    }

    public static bool operator ==(Give? left, Give? right)
    {
        return EqualityComparer<Give>.Default.Equals(left, right);
    }

    public static bool operator !=(Give? left, Give? right)
    {
        return !(left == right);
    }
}