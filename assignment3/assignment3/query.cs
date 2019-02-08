using System;

public class Class1
{
	public Class1()
	{
           public void ListofProducts(products[] productList) {
            foreach (var i in productList)
            {
                Console.WriteLine(i.name, i.type, i.quantity, i.price);
            }
        }
    }
}
