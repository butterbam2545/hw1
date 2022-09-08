public class shop {string name; double number; string owner_name; double registered_value; string money_value;

    int thousand, five_hundred, one_hundred, fifty, twenty, ten, two, one, point_five, point_two_five;

    public shop(string money_value){
        this.money_value = money_value;
    }

    public shop(string name, double number, string owner_name ,double registered_value){
        this.name = name;
        this.number = number;
        this.owner_name = owner_name;
        this.registered_value = registered_value;
    }

    public void PrintInformation(){
        Console.WriteLine("**********************************");
        Console.WriteLine($"Name = {name}");
        Console.WriteLine($"Number = {number}");
        Console.WriteLine($"Owner_name = {owner_name}");
        Console.WriteLine($"Store Name = {registered_value}");
        Console.WriteLine($"Store Value = {money_value}");
        Console.WriteLine("**********************************");
    }

    public void ExchangeMoney(){
        string[] partstring = money_value.Split('.');
        int intergerpart = CheckTypeInterger(partstring[0]);
        int decemalpart = CheckTypeDecemal(partstring[1]);
        if(SpecialDecimal(decemalpart)) decemalpart *= 100;
        if(CheckInteger(intergerpart) && CheckDecimal(decemalpart) && SpecialDecimal(decemalpart)) throw new Exception("incorrect");
        else {
            Calculater(intergerpart, decemalpart);
            PrintCalculator();
        }
    }

    public int CheckTypeInterger(string intergerpart){
        if(int.TryParse(intergerpart, out int num)){
            return num;
        }
        else{
            throw new Exception("Incorrect Interger");
        }
    }

    public int CheckTypeDecemal(string decemalpart){
        if(int.TryParse(decemalpart, out int num)){
            return num;
        }
        else{
            throw new Exception("Incorrect Decemal");
        }
    }

    public bool CheckInteger(int intergerpart){
        if(intergerpart > 0){
            return false;
        }
        
        return true;
    }

    public bool CheckDecimal(int decimalpart){
        if(decimalpart >= 25 && decimalpart != 50 && decimalpart <= 75){
            return false;
        }
        
        return true;
    }

    public bool SpecialDecimal(int decimalpart){
        if(decimalpart >= 1 && decimalpart <= 9){
            return true;
        }
        return false;
    }

    public void Calculater(int intergerpart, int decimalpart){
        thousand = intergerpart / 1000;
        intergerpart %= 1000;
        five_hundred = intergerpart / 500;
        intergerpart %= 500;
        one_hundred = intergerpart / 100;
        intergerpart %= 100;
        fifty = intergerpart / 50;
        intergerpart %= 50;
        twenty = intergerpart / 20;
        intergerpart %= 20;
        ten = intergerpart / 10;
        intergerpart %= 10;
        two = intergerpart / 2;
        intergerpart %= 2;
        one = intergerpart / 1;
        intergerpart %= 1;
        point_five = decimalpart / 50;
        decimalpart %= 50;
        point_two_five = decimalpart / 25;
        decimalpart %= 25;
    }

    public void PrintCalculator(){
        Console.WriteLine("1000 : " + thousand + "\n" + 
        "500 : " + five_hundred + "\n" + 
        "100 : " + one_hundred + "\n" + 
        "50 : " + fifty + "\n" + 
        "20 : " + twenty + "\n" + 
        "10 : " + ten + "\n" +  
        "2 : " + two + "\n" + 
        "1 : " + one + "\n" +  
        ".50 : " + point_five + "\n" +  
        ".25 : " + point_two_five);
    }

    public string Name{
        get{ return name;}
        set {name = value;}
    }
    public double Number{
        get{ return number;}
        set {number = value;}
    }
    public string Owner_name{
        get{ return owner_name;}
        set {owner_name = value;}
    }
    public string StoreName{
        get{ return owner_name;}
        set {owner_name = value;}
    }
    public double Value{
        get{ return registered_value;}
        set {this.registered_value = value;}
    }
}