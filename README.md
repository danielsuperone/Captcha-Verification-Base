# VerificationCaptcha - CAPTCHA Generator 🖼️

Welcome to the **VerificationCaptcha** project! This simple CAPTCHA generator is perfect for your applications to protect forms and verify human interaction.

---

## 🚀 Features

- **Random CAPTCHA Generation**: Generates random alphanumeric CAPTCHA images. 
- **Customizable Design**: Adjust colors, fonts, and text for a personalized look.
- **User-Friendly**: Easy integration into any Windows Forms application.
- **Text Matching**: Supports case-insensitive text matching for easy validation.

---

## 💻 Installation & Setup

1. **Clone this repository**:

   ```bash
   git clone https://github.com/yourusername/VerificationCaptcha.git
   
2) Open the project in Visual Studio.

3) Build and Run the application by pressing F5 or clicking the build button at the top of Visual Studio.

![image](https://i.imgur.com/atJZRFt.png)

---

## 🔧 How It Works
<details> <summary>Click to expand</summary>
  
# ✅ Here’s how it works:


- [x] `Random Character Generation:` The system randomly selects characters (letters and digits) for the CAPTCHA.

- [x] `Drawing the Text:` The chosen characters are drawn on an image with a variety of fonts from a predefined list.

- [x] `Image Customization:` Background and text colors are customizable, and the text is positioned randomly on the image.

- [x] `Font and Styling:` A mix of fonts is used to make the CAPTCHA harder for bots to decipher.

- [x] `Text Validation:` The entered text is compared with the CAPTCHA answer, and case-sensitivity can be configured.

</details>

---

## 📝 Code Explanation
<details> <summary>Click to expand</summary>
  
- [x] Captcha.cs: Handles the logic for generating random characters, drawing them on an image, and validating the text input.

- [x] CaptchaAnswer: Stores the generated CAPTCHA text.

- [x] GenerateImage(): Generates the CAPTCHA image with random characters.

- [x] DrawText(): Draws the text on the image with random fonts and colors.

- [x] Form1.cs: The main form that displays the CAPTCHA image and validates user input.

- [x] button1_Click(): Refreshes the CAPTCHA image when clicked.

- [x] button3_Click(): Validates the input against the generated CAPTCHA answer.

- [x] Form1.Designer.cs: Manages the layout and UI components like buttons, textboxes, and the CAPTCHA image.

</details>

---

## 💡 Customization
You can easily modify the following:

- [x] `Font List:` Change the fonts in the FontList() method to add/remove fonts.

- [x] `Character Length:` Modify the charlength variable to adjust the CAPTCHA length.

- [x] `Background and Text Colors:` Customize the backColor and textColor in the DrawText() method.

---

## ⚙️ Dependencies
.NET Framework (for Windows Forms application)

Windows Forms (for UI elements like buttons, textboxes, and images)
