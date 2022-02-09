using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ToDo.Domain.Commands;

namespace ToDo.Domain.Tests;

[TestClass]
public class CreateTodoCommandTests
{
    private readonly CreateTodoCommand _invalidCommand = new CreateTodoCommand("", "", DateTime.Now);

    private readonly CreateTodoCommand _validCommand = new CreateTodoCommand("Comando valido", "usuario valido", DateTime.Now);
    public CreateTodoCommandTests()
    {
        _invalidCommand.Validate();
        _validCommand.Validate();
    }
    [TestMethod]
    public void Dado_um_comando_invalido()
    {
        
        Assert.AreEqual(_invalidCommand.Valid, false);
    }
    [TestMethod]
    public void Dado_um_comando_valido()
    {
        
        Assert.AreEqual(_validCommand.Valid, true);
    }
}