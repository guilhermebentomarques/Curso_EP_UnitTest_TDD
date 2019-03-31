﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Banco.Domain.Tests.Automatizados.Conta_Corrente
{
    using TechTalk.SpecFlow;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class DepositoEmContaCorrenteFeature : Xunit.IClassFixture<DepositoEmContaCorrenteFeature.FixtureData>, System.IDisposable
    {

        private static TechTalk.SpecFlow.ITestRunner testRunner;

        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;

#line 1 "ContaCorrente.feature"
#line hidden

        public DepositoEmContaCorrenteFeature(DepositoEmContaCorrenteFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }

        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "Deposito em conta corrente", "\t\t\t\t\toperacoes de deposito em conta\r\n\t\t\t\t\tdo tipo conta corrente", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }

        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }

        public virtual void TestInitialize()
        {
        }

        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }

        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }

        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }

        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }

        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }

        [Xunit.FactAttribute(DisplayName = "Deposito Realizado Com Sucesso")]
        [Xunit.TraitAttribute("FeatureTitle", "Deposito em conta corrente")]
        [Xunit.TraitAttribute("Description", "Deposito Realizado Com Sucesso")]
        public virtual void DepositoRealizadoComSucesso()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deposito Realizado Com Sucesso", null, ((string[])(null)));
#line 5
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
            testRunner.Given("Uma conta corrente ativa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 7
            testRunner.When("O valor for depositado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 8
            testRunner.And("o valor é superior a zero", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 9
            testRunner.Then("Receberei uma mensagem de deposito realizado com sucesso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }

        [Xunit.FactAttribute(DisplayName = "Deposito com valor negativo ou igual a zero")]
        [Xunit.TraitAttribute("FeatureTitle", "Deposito em conta corrente")]
        [Xunit.TraitAttribute("Description", "Deposito com valor negativo ou igual a zero")]
        public virtual void DepositoComValorNegativoOuIgualAZero()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deposito com valor negativo ou igual a zero", null, ((string[])(null)));
#line 11
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
            testRunner.Given("Uma conta corrente ativa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 13
            testRunner.When("O valor for depositado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 14
            testRunner.And("O valor é negativo ou igual zero", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 15
            testRunner.Then("Receberei uma mensagem de falha na transacao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }

        [Xunit.FactAttribute(DisplayName = "Deposito com valor acima do limite")]
        [Xunit.TraitAttribute("FeatureTitle", "Deposito em conta corrente")]
        [Xunit.TraitAttribute("Description", "Deposito com valor acima do limite")]
        public virtual void DepositoComValorAcimaDoLimite()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deposito com valor acima do limite", null, ((string[])(null)));
#line 17
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 18
            testRunner.Given("Uma conta corrente ativa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 19
            testRunner.When("O valor for depositado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Valor"});
            table1.AddRow(new string[] {
                        "1000000"});
#line 20
            testRunner.And("O valor é acima do limite", ((string)(null)), table1, "E ");
#line 23
            testRunner.Then("Receberei uma mensagem de valor acima do limite", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {

            public FixtureData()
            {
                DepositoEmContaCorrenteFeature.FeatureSetup();
            }

            void System.IDisposable.Dispose()
            {
                DepositoEmContaCorrenteFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion