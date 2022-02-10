using Xunit;
using SimpleApi;

namespace SimpleApi.Tests;

public class UnitTest1
{
 ValuesController obj= new ValuesController();   
    [Fact]
    public void Test1()
    {
       var ctr=obj.Get(1);
       Assert.Equal("Bittu",ctr);
       
    }
}