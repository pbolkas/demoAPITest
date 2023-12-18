using DemoAPI.Services;
using DemoAPI.Entities;
using DemoAPI.Entities.Exceptions;
namespace DemoAPITest
{
  public class RequestObjServiceTest
  {
    public readonly IRequestObjService service = new RequestObjService();

    [Test]
    public void TestSecondLargestMethod()
    {
      int num = service.SecondLargest(
        new RequestObjDTO
        {
           requestArrayObj = new List<int> { 1, 2, 3 }
        });
      Assert.That(num, Is.EqualTo(2));
    }


    [Test]
    public void TestSecondLargestMethodOneCellArray()
    {
      int num = service.SecondLargest(
        new RequestObjDTO
        {
           requestArrayObj = new List<int> { 1 }
        });
      Assert.That(num, Is.EqualTo(1));
    }

    [Test]
    public void TestSecondLargestMethodEmptyArray()
    {
      
      Assert.Throws<RequestObjEmptyArrayException>(
        delegate
        {
          service.SecondLargest(
          new RequestObjDTO
          {
            requestArrayObj = new List<int> {}
          });
        }
      );
    }
  }
}