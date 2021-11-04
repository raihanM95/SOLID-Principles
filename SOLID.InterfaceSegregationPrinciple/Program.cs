// See https://aka.ms/new-console-template for more information
//public interface IOrder
//{
//    void AddToCart();
//    void CCProcess();
//}

//public class OnlineOrder : IOrder
//{
//    public void AddToCart()
//    {
//        //Do Add to Cart
//    }

//    public void CCProcess()
//    {
//        //process through credit card
//    }
//}

//public class OfflineOrder : IOrder
//{
//    public void AddToCart()
//    {
//        //Do Add to Cart
//    }

//    public void CCProcess()
//    {
//        //Not required for Cash/ offline Order
//        throw new NotImplementedException();
//    }
//}

/* We can resolve this violation by dividing IOrder Interface. */

public interface IOrder
{
    void AddToCart();
}

public interface IOnlineOrder
{
    void CCProcess();
}

public class OnlineOrder : IOrder, IOnlineOrder
{
    public void AddToCart()
    {
        //Do Add to Cart
    }

    public void CCProcess()
    {
        //process through credit card
    }
}

public class OfflineOrder : IOrder
{
    public void AddToCart()
    {
        //Do Add to Cart
    }
}