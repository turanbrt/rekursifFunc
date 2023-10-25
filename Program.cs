namespace rekursifFunc;

class Program
{
    static void Main(string[] args)
    {
        //retruksif metots
        Operations instance=new Operations();
        int[] arrNum={1,3,5,7,9,11};

        Console.WriteLine(instance.expOp(3,5));

        //extantion METOT
        //verilen stiring içerisinde space var mı kontol eden func tanımla
        string phareseString="TURAN BARUT";
        bool result=phareseString.CheckSpace();
        Console.WriteLine(result);
        if(result){
            Console.WriteLine(phareseString.removeWhiteSpace());
        }
        Console.WriteLine(phareseString.makeUpperCase());
        Console.WriteLine(phareseString.makeLowerCase());
        arrNum.arrSort();
        arrNum.printArr();

        int value1=192;
        Console.WriteLine(value1.isEven());

    }

}

public class Operations{
    public int expOp(int baseNum,int powerNum){
        if(powerNum<=2){
            return baseNum; 
        }
            return baseNum*expOp(baseNum,powerNum-1);
    }  
}
public static class Extension{

    public static bool CheckSpace(this string param){
        //space searcher
       return param.Contains(" ");
    }

    public static string removeWhiteSpace(this string param){
        //param yani gelen string i ' ' boşluklardan ayırıp arr dizisine gönderir
        string[] arr=param.Split(" ");
        Console.WriteLine("arr stringi:"+arr);
        return string.Join("",arr);
    }
    public static string makeUpperCase(this string param){
        
        return param.ToUpper();
    }
    public static string makeLowerCase(this string param){
       //karakterleri kucuk harf yap
        return param.ToLower();
    }
    public static int[] arrSort(this int[] param){
        //int tipinde dizi sıralar
        Array.Sort(param);
       return param;
    }
    public static void printArr(this int[] param){
        //diziyi ekrana yazdir
        foreach(var numbr in param){
            Console.WriteLine(numbr);
        }
    }
    public static bool  isEven(this int param){
        if(param%2==0){
            return true;
        }
        else return false;
    }
}

