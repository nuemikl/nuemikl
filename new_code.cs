class myclass{
    public int a=0;
}
/*
C#中类对象可以看作是一个引用类型，而那些基本的数据类型是值类型
在系统栈中，值类型的数据存储的是这个对象的值，而引用类型数据的
值保存在堆中，栈里只保存这个引用类型数据的地址
这个地址和一般的C指针不一样，引用所代表的地址不能被修改，也
不能转换为其它类型地址，它是引用型变量，只能引用指定类对象，
引用类型变量赋值语句是传递对象的地址。
*/
//值类型变量不能转换为引用类型
class test{
    static void Main(){
       f1();
    }
    static public void f1(){
        int v1=1;
        int v2=v1;//值数据赋值跟一般的赋值一样
        v2=2;//值数据修改时只修改单个对象
        System.Console.WriteLine("v1={0},v2={1}",v1,v2);
        myclass r1=new myclass();
        myclass r2=r1;//引用数据的赋值两个对象的值相同
        r2.a=3;//修改时相当于同一个数据
        System.Console.WriteLine("r1.a={0},r2.a={1}",r1.a,r2.a);
    } 
}