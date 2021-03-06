namespace BlueprintBaseName._1.Tests

open Xunit
open Amazon.Lambda.TestUtilities

open BlueprintBaseName._1


module FunctionTest =

    [<Fact>]
    let ``Invoke ToUpper Lambda Function``() =
        let lambdaFunction = Function()
        let context = TestLambdaContext()
        let upperCase = lambdaFunction.FunctionHandler "hello world"  context
        
        Assert.Equal("HELLO WORLD", upperCase)
    
    [<EntryPoint>]
    let main argv = 0    