// indeks: 347818
// Patryk Nogaś

using System;

public class BigNum
{
    public string val;

    // This is the constructor.
    public BigNum(int value)
    {
        this.val = value.ToString();
    }
    public BigNum(string value)
    {
        this.val = value;
    }

    public void Print()
    {
        Console.WriteLine(this.val);
    }
    public static Object Add(BigNum a, BigNum b, bool should_results_be_negative = false){
        if (a.val[0] == '-' && b.val[0] == '-')
        {
            a.val = a.val.Substring(1);
            b.val = b.val.Substring(1);
            return BigNum.Add(a, b, true);
        }
        else if(a.val[0] =='-'){
            a.val = a.val.Substring(1);
            return BigNum.Substract(b, a);
        }
        else if(b.val[0] == '-'){
            b.val = b.val.Substring(1);
            return BigNum.Add(a, b);
        }
        int carry = 0;
        string results = "";
        while(a.val.Length<b.val.Length){
            a.val = "0" + a.val;
        }
        while(a.val.Length>b.val.Length){
            b.val = "0" + b.val;
        }
        int i = a.val.Length - 1;
        while(i >= 0){
            results = (((a.val[i] + b.val[i] - 2 * '0' + carry) % 10).ToString()) + results;
            carry = ((a.val[i] + b.val[i] - 2 * '0' + carry) / 10);
            i--;
        }
        if(carry > 0){
            results = (carry.ToString()) + results;
        }
        if(should_results_be_negative){
            results = "-" + results;
        }
        return new BigNum(results);
    }
    public static Object Add(BigNum a, BigNum b){
        return BigNum.Add(a, b, false);
    }

    public static Object Substract(BigNum a, BigNum b, bool should_results_be_negative = false){
        if(a.val[0] =='-'){
            a.val = a.val.Substring(1);
            return BigNum.Substract(b, a);
        }
        else if(b.val[0] == '-'){
            b.val = b.val.Substring(1);
            return BigNum.Add(a, b);
        }
        int carry = 0;
        string results = "";
        while(a.val.Length<b.val.Length){
            a.val = "0" + a.val;
        }
        while(a.val.Length>b.val.Length){
            b.val = "0" + b.val;
        }
        int i = a.val.Length - 1;
        if(ktora_jest_wieksza(a, b)){
            return BigNum.Substract(b, a, true);
        }
        while(i >= 0){
            int dana_liczba = a.val[i] - b.val[i] - carry;
            if(dana_liczba < 0){
                dana_liczba += 10;
                carry = 1;
            }
            else{
                carry = 0;
            }
            results = (dana_liczba.ToString()) + results;
            i--;}
        if(carry > 0){
            results = (carry.ToString()) + results;
        }
        if(should_results_be_negative){
            results = "-" + results;
        }
        return new BigNum(results);
    }
    public static bool ktora_jest_wieksza(BigNum a, BigNum b){
        for(int i = 0; i < a.val.Length; i++){
            if(a.val[i] > b.val[i]){
                return false;
            }
            if(a.val[i] < b.val[i]){
                return true;
            }
        }
        return false;
    }

}

class MainProgram{
    public static void Main(string[] args){
        BigNum a = new BigNum(-123);
        BigNum b = new BigNum("-321");
        BigNum c = (BigNum) BigNum.Add(a, b);
        BigNum d = (BigNum) BigNum.Substract(a, b);
        c.Print();
        d.Print();
        
    }
}
