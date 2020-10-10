// NOTE: this file is autogenerated. Any changes will be overwritten!
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using MudBlazor.UnitTests.Mocks;
using MudBlazor.Docs;
using MudBlazor.Dialog;

namespace MudBlazor.UnitTests.Components
{
    [TestFixture]
    public class _AllComponents
    {
        // These tests just check if all the examples from the doc page render without errors



        [Test]
        public void InstallExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<InstallExample>();
        }


        [Test]
        public void LinksExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<LinksExample>();
        }


        [Test]
        public void LinksMinimalExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<LinksMinimalExample>();
        }


        [Test]
        public void UsageExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<UsageExample>();
        }


        [Test]
        public void UsageMinimalExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<UsageMinimalExample>();
        }


        [Test]
        public void UsingExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<UsingExample>();
        }


        [Test]
        public void AppBarDenseExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<AppBarDenseExample>();
        }


        [Test]
        public void AppBarElevationExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<AppBarElevationExample>();
        }


        [Test]
        public void AppBarSimpleExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<AppBarSimpleExample>();
        }


        [Test]
        public void ButtonCustomizedExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<ButtonCustomizedExample>();
        }


        [Test]
        public void ButtonElevationExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<ButtonElevationExample>();
        }


        [Test]
        public void ButtonFilledExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<ButtonFilledExample>();
        }


        [Test]
        public void ButtonIconLabelExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<ButtonIconLabelExample>();
        }


        [Test]
        public void ButtonOutlinedExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<ButtonOutlinedExample>();
        }


        [Test]
        public void ButtonSizeExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<ButtonSizeExample>();
        }


        [Test]
        public void ButtonTextExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<ButtonTextExample>();
        }


        [Test]
        public void CardCombinedExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<CardCombinedExample>();
        }


        [Test]
        public void CardHeaderExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<CardHeaderExample>();
        }


        [Test]
        public void CardMediaExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<CardMediaExample>();
        }


        [Test]
        public void CardOutlinedExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<CardOutlinedExample>();
        }


        [Test]
        public void CardSimpleExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<CardSimpleExample>();
        }


        [Test]
        public void CheckboxBasicExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<CheckboxBasicExample>();
        }


        [Test]
        public void CheckboxLabelExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<CheckboxLabelExample>();
        }


        [Test]
        public void ContainedFixedExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<ContainedFixedExample>();
        }


        [Test]
        public void ContainerFluidExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<ContainerFluidExample>();
        }


        [Test]
        public void DialogDialogFormExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<DialogDialogFormExample>();
        }


        [Test]
        public void DialogDialogOptionExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<DialogDialogOptionExample>();
        }


        [Test]
        public void DialogDialogSimpleExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<DialogDialogSimpleExample>();
        }


        [Test]
        public void DialogFormExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<DialogFormExample>();
        }


        [Test]
        public void DialogOptionsExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<DialogOptionsExample>();
        }


        [Test]
        public void DialogSimpleExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<DialogSimpleExample>();
        }


        [Test]
        public void DividerInsertExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<DividerInsertExample>();
        }


        [Test]
        public void DividerListExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<DividerListExample>();
        }


        [Test]
        public void DividerMiddleExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<DividerMiddleExample>();
        }


        [Test]
        public void DividerVerticalExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<DividerVerticalExample>();
        }


        [Test]
        public void DrawerClippingExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<DrawerClippingExample>();
        }


        [Test]
        public void DrawerCombinedExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<DrawerCombinedExample>();
        }


        [Test]
        public void DrawerPersistentExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<DrawerPersistentExample>();
        }


        [Test]
        public void ExpansionPanelDisabledExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<ExpansionPanelDisabledExample>();
        }


        [Test]
        public void ExpansionPanelMultiExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<ExpansionPanelMultiExample>();
        }


        [Test]
        public void ExpansionPanelSimpleExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<ExpansionPanelSimpleExample>();
        }


        [Test]
        public void FabSimpleExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<FabSimpleExample>();
        }


        [Test]
        public void FabSizeExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<FabSizeExample>();
        }


        [Test]
        public void GridBasicExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<GridBasicExample>();
        }


        [Test]
        public void GridSpacingExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<GridSpacingExample>();
        }


        [Test]
        public void IconButtonSimpleExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<IconButtonSimpleExample>();
        }


        [Test]
        public void IconToggleButtonExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<IconToggleButtonExample>();
        }


        [Test]
        public void IconsColorExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<IconsColorExample>();
        }


        [Test]
        public void IconsFontAwesomeExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<IconsFontAwesomeExample>();
        }


        [Test]
        public void IconsFontIconsExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<IconsFontIconsExample>();
        }


        [Test]
        public void IconsFontMaterialIconsExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<IconsFontMaterialIconsExample>();
        }


        [Test]
        public void IconsSizeExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<IconsSizeExample>();
        }


        [Test]
        public void IconsUsageExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<IconsUsageExample>();
        }


        [Test]
        public void LinkSimpleExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<LinkSimpleExample>();
        }


        [Test]
        public void LinkUnderlineExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<LinkUnderlineExample>();
        }


        [Test]
        public void ListFolderExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<ListFolderExample>();
        }


        [Test]
        public void ListNestedExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<ListNestedExample>();
        }


        [Test]
        public void ListSimpleExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<ListSimpleExample>();
        }


        [Test]
        public void NavMenuExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<NavMenuExample>();
        }


        [Test]
        public void PaperComponentExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<PaperComponentExample>();
        }


        [Test]
        public void PaperVariantsExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<PaperVariantsExample>();
        }


        [Test]
        public void ProgressCircularInterminateExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<ProgressCircularInterminateExample>();
        }


        [Test]
        public void ProgressCircularStaticExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<ProgressCircularStaticExample>();
        }


        [Test]
        public void ProgressLinearInterminateExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<ProgressLinearInterminateExample>();
        }


        [Test]
        public void RadioGroupExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<RadioGroupExample>();
        }


        [Test]
        public void RadioLabelPlacementExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<RadioLabelPlacementExample>();
        }


        [Test]
        public void SelectBasicExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<SelectBasicExample>();
        }


        [Test]
        public void SimpleTableExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<SimpleTableExample>();
        }


        [Test]
        public void SimpleTableHoverDenseExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<SimpleTableHoverDenseExample>();
        }


        [Test]
        public void SliderBasicExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<SliderBasicExample>();
        }


        [Test]
        public void SliderStepsExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<SliderStepsExample>();
        }


        [Test]
        public void SwitchBasicExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<SwitchBasicExample>();
        }


        [Test]
        public void SwitchWithLabelExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<SwitchWithLabelExample>();
        }


        [Test]
        public void TableExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<TableExample>();
        }


        [Test]
        public void TableFixedHeaderExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<TableFixedHeaderExample>();
        }


        [Test]
        public void TableMultiSelectExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<TableMultiSelectExample>();
        }


        [Test]
        public void TabsCenteredExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<TabsCenteredExample>();
        }


        [Test]
        public void TabsDisabledExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<TabsDisabledExample>();
        }


        [Test]
        public void TabsIconAndTextExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<TabsIconAndTextExample>();
        }


        [Test]
        public void TabsIconExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<TabsIconExample>();
        }


        [Test]
        public void TabsSimpleExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<TabsSimpleExample>();
        }


        [Test]
        public void TabsVerticalExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<TabsVerticalExample>();
        }


        [Test]
        public void TemplateExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<TemplateExample>();
        }


        [Test]
        public void TextFieldBasicExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<TextFieldBasicExample>();
        }


        [Test]
        public void TextFieldFormPropsExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<TextFieldFormPropsExample>();
        }


        [Test]
        public void TextFieldInputsExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<TextFieldInputsExample>();
        }


        [Test]
        public void ThemesCustomExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<ThemesCustomExample>();
        }


        [Test]
        public void ThemesDefaultExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<ThemesDefaultExample>();
        }


        [Test]
        public void TooltipDelayedExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<TooltipDelayedExample>();
        }


        [Test]
        public void TooltipPostionExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<TooltipPostionExample>();
        }


        [Test]
        public void TooltipSimpleExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<TooltipSimpleExample>();
        }


        [Test]
        public void TextAlignmentExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<TextAlignmentExample>();
        }


        [Test]
        public void TextGeneralExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<TextGeneralExample>();
        }


        [Test]
        public void ElevationUsageExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<ElevationUsageExample>();
        }


        [Test]
        public void SpacingExample_Test()
        {
                using var ctx = new Bunit.TestContext();
                ctx.Services.AddSingleton<NavigationManager>(new MockNavigationManager());
                ctx.Services.AddSingleton<IDialogService>(new DialogService());
                var comp = ctx.RenderComponent<SpacingExample>();
        }

    }
}

