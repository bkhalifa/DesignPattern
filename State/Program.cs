// See https://aka.ms/new-console-template for more information
using DP.Logic.State;

Console.Title = "State";

BankAccount bankAccount = new();

bankAccount.Deposit(100);
bankAccount.WithDraw(500);
bankAccount.WithDraw(100);