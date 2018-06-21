# Guide: Getting Started With Shell (Early Preview)

Shell is a new container for your Xamarin.Forms applications that provides several key benefits. 

- Beautifully themed UI by default, beginning with Material Design
- Modern navigation UI out-of-the-box via a Flyout control
- Navigate via routes 
- Performance!
- Unified design by default (not yet implemented)


# Pre-requisites

## Preview NuGet

We have posted a preview of Xamarin.Forms that includes a very early preview of Shell. [Download the packages here](https://github.com/davidortinau/Gastropods/raw/master/Bits/NuGet.zip) and add them to your local NuGet source.

## Limitations

Android and iOS are the most complete platforms. UWP is in progress. No other platforms are part of the initial release plan.

# Getting Started

Add a new XAML file call `Shell.xaml`. Replace the `ContentPage` with this sample code:

> Note to change your application namespace from Gastropod  to your own app name.

```
<?xml version="1.0" encoding="utf-8" ?>
<Shell xmlns="http://xamarin.com/schemas/2014/forms"
            xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
            xmlns:local="clr-namespace:Gastropod"
            Route="gastropod"
            RouteHost="www.xamarin.com"
            RouteScheme="http"
            x:Class="Gastropod.Shell">
    <Shell.FlyoutHeader>
        <local:FlyoutHeader />
    </Shell.FlyoutHeader>
</Shell>
```

Open `Shell.xaml.cs` and updated it to extend `Shell` instead of `ContentPage`.

```
public partial class Shell : Xamarin.Forms.Shell
```

Open `App.xaml.cs` and assign  your new `Shell`  to `MainPage`.

```
public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new Shell();
    }
}
```

For several examples of creating different app variations, see the original [GitHub issue](https://github.com/xamarin/Xamarin.Forms/issues/2415).
- Single page
- 2 page with tabs
- 2 page with top and bottom tabs
- 2 page with flyout menu

## Definitions

| Term | Definition  |
|--------------------|---------------------------|
| Flyout         | The menu for the application  accessible via the hamburger button or swiping off the side. The behavior of the `Flyout` is set via the `FlyoutBehavior` on the `Shell` itself.                |
| FlyoutHeader         | The template for content that appears at the top of the `Flyout`.           |
| MenuItem        | A menu item to appear in the Flyout when a `ShellContent` is the presented page. |
| Route        | The URI segment used to navigate within the app to this page. |
| Shell    | The top level container of your appication. All children are `ShellItem`s.               |
| ShellContent              | The `Shell` representation of a  `ContentPage`.                  |
| ShellItem              | Represents a top level section of your application. You can have 1 or more. By default these populate the `Flyout`. `ShellItem`s contain `ShellSection`s.                  |
| ShellSection              | A grouping of  `ShellContent` within a `ShellItem`.                  |

Here is an example of a 2 page app with tabs at the bottom:

```
<Shell xmlns="http://xamarin.com/schemas/2014/forms"
       xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
       xmlns:local="clr-namespace:MyStore"
       FlyoutBehavior="Disabled"
       x:Class="MyStore.Shell">

  <ShellItem>

    <ShellSection Title="Home" Icon="home.png">
      <ShellContent>
        <local:HomePage />
      </ShellContent>
    </ShellSection>

    <ShellSection Title="Notifications" Icon="bell.png">
      <ShellContent>
        <local:NotificationsPage />
      </ShellContent>
    </ShellSection>

  </ShellItem>
</Shell>
```

## Adding Pages

Each page or screen in a `Shell` app is represented by a `ShellContent`. The `ContentPage` is set via a `DataTemplate` to prevent the pages from being instantiated until they are required

```
<ShellContent Route="home" Title="Home" ContentTemplate="{DataTemplate local:MainPage}"/>
<ShellContent Route="feed" Title="Feed" ContentTemplate="{DataTemplate local:FeedPage}"/>
```

This could also be represented as:

```
<ShellContent Route="home" Title="Home">
    <local:MainPage />
</ShellContent>
<ShellContent Route="feed" Title="Feed">
    <local:FeedPage />
</ShellContent>
```

## Navigation Routes

Navigation through a `Shell` application is handled via URIs. From the example above, the 2 pages are navigable via different routes, "home" and "feed". By simply naming the routes, Xamarin.Forms can handle all the navigation for you.

`[Shell.RouteScheme]://[Shell.RouteHost]/[Shell]/[ShellItem]/[ShellSection]/[ShellContent]/[NavStack1]/[NavStack2]`


## A More Advanced Example

The Xamarin.Forms [shell branch](https://github.com/xamarin/Xamarin.Forms/blob/shell/Xamarin.Forms.Controls/XamStore/StoreShell.xaml) includes a working replica of the Google Play Store navigation model, and then some.

## Design and Styling

`Shell` and related  items can be styled like any other Xamarin.Forms control.

```
<Shell.Resources>
    <Style x:Key="BaseStyle" TargetType="Element">
        <Setter Property="Shell.ShellBackgroundColor" Value="#455A64" />
        <Setter Property="Shell.ShellForegroundColor" Value="White" />
        <Setter Property="Shell.ShellTitleColor" Value="White" />
        <Setter Property="Shell.ShellDisabledColor" Value="#B4FFFFFF" />
        <Setter Property="Shell.ShellUnselectedColor" Value="#95FFFFFF" />
    </Style>
    <Style TargetType="ShellItem" BasedOn="{StaticResource BaseStyle}" />
    <Style x:Key="GreenShell" TargetType="Element" BasedOn="{StaticResource BaseStyle}">
        <Setter Property="Shell.ShellBackgroundColor" Value="#689F39" />
    </Style>
    <Style x:Key="MusicShell" TargetType="Element" BasedOn="{StaticResource BaseStyle}">
        <Setter Property="Shell.ShellBackgroundColor" Value="#EF6C00" />
    </Style>
    <Style x:Key="MoviesShell" TargetType="Element" BasedOn="{StaticResource BaseStyle}">
        <Setter Property="Shell.ShellBackgroundColor" Value="#ED3B3B" />
    </Style>
    <Style x:Key="BooksShell" TargetType="Element" BasedOn="{StaticResource BaseStyle}">
        <Setter Property="Shell.ShellBackgroundColor" Value="#039BE6" />
    </Style>
    <Style x:Key="NewsShell" TargetType="Element" BasedOn="{StaticResource BaseStyle}">
        <Setter Property="Shell.ShellBackgroundColor" Value="#546DFE" />
    </Style>
</Shell.Resources>
```

At this time `Shell` is implementing [Material Design](https://material.io/). Some Material appearance options are available to you now:

```
<ShellItem.ShellAppearance>
      <MaterialShellAppearance NavBarCollapseStyle="Full" TabBarCollapseStyle="Full" UseSwipeGesture="false">
</ShellItem.ShellAppearance>
```

In the future we'll be adding an iOS themed Shell, and a Xamarin Shell where iOS and Android adhere to their platform themes by default. 

> NOTE! Until we implement the full extent of the [Drawing spec](https://github.com/xamarin/Xamarin.Forms/issues/2452), the design of controls will still be rooted in the native UI tool kit for each platform. Drawing aims to provide an optional path to easily achieving the same UI design across multiple platforms.


# We Want Your Feedback!

After you have some time to explore `Shell` and take a run at various scenarios, please take a few minutes to complete this survey.

[Take the Survey (coming soon)](#tbd)

Find something that isn't working? Could be it's not yet implemented, but [file an issue](https://github.com/xamarin/Xamarin.Forms/issues/new) nevertheless. Prefix the title with `[Shell]` please.

