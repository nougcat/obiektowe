// indeks: 347818
// Patryk Nogaś

using System;

class IntStream{
    private int value;
    
    public IntStream(int value=0){
        this.value = value;
    }
    public int next(){
        this.value++;
        return this.value;
    }
    public void reset(){
        this.value = 0;
    }
    public bool eos(){
        if(this.value == int.MaxValue){
            return true;
        }
        else
        {
        return false;
        }
    }
}

class FibStream: IntStream{
    private int prev;
    private int value;
    public FibStream(){
        this.value = 1;
        this.prev = 1;
    }
    public new int next(){
        int temp = value;
        this.value += prev;
        this.prev = temp;
        return value;
    }
    public void reset(){
        this.value = 1;
        this.prev = 1;
    }
}

class RandomStream: IntStream{
    private int value;
    Random rnd = new Random();
    public RandomStream()
    {
        
    }
    public int next(){
        this.value = rnd.Next();

        return this.value;
    }
    public bool eos(){
        return false;
    }
}

class RandomWordStream{

    private string result;
    
    // kolejne liczby fib
    FibStream fib_stream_for_this_class = new FibStream();

    RandomStream random_stream = new RandomStream();


    public RandomWordStream(){
        // stream = new RandomStream(a, b, m);
        // this.chars = chars;
    }
    public string next(){
        RandomStream random_stream = new RandomStream();
        int i_end = fib_stream_for_this_class.next();
        for(int i = 0; i < i_end; i++){

            result += (char)('a' + random_stream.next() % 26);
        }
        return result;
    }
}

class MainClass{
    public static void Main(){
        IntStream int_stream = new IntStream();
        Console.WriteLine("IntStream");
        for(int i = 0; i < 10; i++){
            Console.WriteLine(int_stream.next());
        }
        Console.WriteLine("FibStream");
        FibStream fib_stream = new FibStream();

        for(int i = 0; i < 10; i++){
            Console.WriteLine(fib_stream.next());
        }
        Console.WriteLine("Fibstream eos = {0}",fib_stream.eos());

        Console.WriteLine("RandomStream");
        RandomStream random_stream = new RandomStream();

        for(int i = 0; i < 10; i++){
            Console.WriteLine(random_stream.next());
        }

        Console.WriteLine("Random Word Stream");
        RandomWordStream rws = new RandomWordStream();
        for(int i = 0; i < 10; i++){
            Console.WriteLine(rws.next());
        }

    }
}
