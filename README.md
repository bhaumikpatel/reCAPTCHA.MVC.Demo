# Google reCAPTCHA MVC

Protect your website from spam and abuse while letting real people pass through with ease

Basic useful feature list:

 * reCAPTCHA API verion 2.0 Support
 * The color theme of the widget. (dark, light)
 * The type of CAPTCHA to serve. (audio, image)


### Installing reCAPTCHA for MVC
If the Package Manager Console is not visible in your Microsoft Visual Studio IDE, click on the **Tools > Library Package Manager > Package Manager Console** menu.

```
PM> Install-Package reCAPTCH.MVC
```

### How to Set reCAPTCHA Key in Web.config File

In the **appSettings** section of your web.config file, add the keys as follows:

```xml
<appSettings>
<add name="reCaptchaPublicKey" value="Your site key" />
<add name="reCaptchaPrivateKey" value="Your secret key" />
</appSettings>
```

**Note:** The **appSettings** keys are automatically added to your web.config file if you install reCAPTCHA for .NET through Nuget. However, you would still need to provide your own public and private keys in the web.config file of your project.

### How to Use reCAPTCHA in MVC Web Application

```csharp
@using reCAPTCHA.MVC
@using (Html.BeginForm())
{
    @Html.Recaptcha(publicKey:"xxxxxxxxxxxxx",theme: CaptchaTheme.Dark,type:CaptchaType.Image, 
            callback: "verifyCallback",expiredCallback:"expiredCallback")

    <!-- OR -->
    @Html.Recaptcha()

    @Html.ValidationMessage("ReCaptcha")
    <input type="submit" value="Register" />
}
```
