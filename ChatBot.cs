using System;
using System.Globalization;
using System.Threading;

namespace CyberSecurityChatBot
{
    public class ChatBot
    {
        public string UserName { get; set; } = "";

        public void Start()
        {
            TypeText("Hello there  What is your name?");
            UserName = Console.ReadLine() ?? "";

            while (string.IsNullOrWhiteSpace(UserName))
            {
                TypeText("Oops I didn’t catch your name. Please type your name so we can continue:");
                UserName = Console.ReadLine() ?? "";
            }

            UserName = CapitalizeName(UserName);

            TypeText($"\nWelcome {UserName}!");
            TypeText("I am KANYA SHIELD, your Cybersecurity Awareness Assistant.");
            TypeText("I’m here to help you stay safe online and learn about cybersecurity.");

            ShowMenu();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"\n{UserName}: ");
                Console.ResetColor();

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    TypeText("Goodbye Stay safe online and protect your digital world!");
                    break;
                }

                string input = "";

                if (keyInfo.Key != ConsoleKey.Enter)
                {
                    Console.Write(keyInfo.KeyChar);
                    input = keyInfo.KeyChar + (Console.ReadLine() ?? "");
                }

                input = input.Trim().ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    TypeText("No worries  Please type a number (1–29) or ask a question.");
                    continue;
                }

                if (input == "x" || input == "exit")
                {
                    TypeText("Goodbye Stay safe online!");
                    break;
                }

                if (input == "help" || input == "menu")
                {
                    ShowMenu();
                    continue;
                }

                Respond(input);
            }
        }

        // ================= NAME =================
        private string CapitalizeName(string name)
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(name.Trim().ToLower());
        }

        // ================= MENU =================
        private void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n================ AVAILABLE QUESTIONS ================");
            Console.ResetColor();

            Console.WriteLine(" 1. How are you?");
            Console.WriteLine(" 2. What is your purpose?");
            Console.WriteLine(" 3. What is phishing?");
            Console.WriteLine(" 4. How do I create a strong password?");
            Console.WriteLine(" 5. What is malware?");
            Console.WriteLine(" 6. What is ransomware?");
            Console.WriteLine(" 7. How can I browse safely?");
            Console.WriteLine(" 8. What are suspicious links?");
            Console.WriteLine(" 9. How do I avoid scams?");
            Console.WriteLine("10. What is two-factor authentication?");
            Console.WriteLine("11. Why is cybersecurity important?");
            Console.WriteLine("12. What should I do if I get hacked?");
            Console.WriteLine("13. How do I protect my personal information?");
            Console.WriteLine("14. What is social engineering?");
            Console.WriteLine("15. What is a firewall?");
            Console.WriteLine("16. What is a VPN?");
            Console.WriteLine("17. What is identity theft?");
            Console.WriteLine("18. How do I keep my phone safe?");
            Console.WriteLine("19. How do I stay safe on social media?");
            Console.WriteLine("20. How do I avoid fake websites?");
            Console.WriteLine("21. What is cyberbullying?");
            Console.WriteLine("22. How do I update my software?");
            Console.WriteLine("23. What are email attachment risks?");
            Console.WriteLine("24. How do I secure online banking?");
            Console.WriteLine("25. What is data privacy?");
            Console.WriteLine("26. How do I know if a website is safe?");
            Console.WriteLine("27. How can students stay safe online?");
            Console.WriteLine("28. What is spyware?");
            Console.WriteLine("29. What is antivirus?");

            Console.WriteLine("\nType a number (1–29) OR type your question.");
            Console.WriteLine("Type 'help' to see this again.");
            Console.WriteLine("Type 'X' or press 'ESC' to exit.");
        }

        // ================= INPUT HANDLING =================
        private void Respond(string input)
        {
            if (int.TryParse(input, out int num))
            {
                AnswerByNumber(num);
                return;
            }

            if (input.Contains("how are you")) AnswerByNumber(1);
            else if (input.Contains("purpose")) AnswerByNumber(2);
            else if (input.Contains("phishing")) AnswerByNumber(3);
            else if (input.Contains("password")) AnswerByNumber(4);
            else if (input.Contains("malware")) AnswerByNumber(5);
            else if (input.Contains("ransomware")) AnswerByNumber(6);
            else if (input.Contains("browse")) AnswerByNumber(7);
            else if (input.Contains("link")) AnswerByNumber(8);
            else if (input.Contains("scam")) AnswerByNumber(9);
            else if (input.Contains("two-factor") || input.Contains("2fa")) AnswerByNumber(10);
            else if (input.Contains("important")) AnswerByNumber(11);
            else if (input.Contains("hacked")) AnswerByNumber(12);
            else if (input.Contains("personal")) AnswerByNumber(13);
            else if (input.Contains("social engineering")) AnswerByNumber(14);
            else if (input.Contains("firewall")) AnswerByNumber(15);
            else if (input.Contains("vpn")) AnswerByNumber(16);
            else if (input.Contains("identity")) AnswerByNumber(17);
            else if (input.Contains("phone")) AnswerByNumber(18);
            else if (input.Contains("social media")) AnswerByNumber(19);
            else if (input.Contains("fake")) AnswerByNumber(20);
            else if (input.Contains("cyberbullying")) AnswerByNumber(21);
            else if (input.Contains("software")) AnswerByNumber(22);
            else if (input.Contains("attachment")) AnswerByNumber(23);
            else if (input.Contains("banking")) AnswerByNumber(24);
            else if (input.Contains("privacy")) AnswerByNumber(25);
            else if (input.Contains("website")) AnswerByNumber(26);
            else if (input.Contains("students")) AnswerByNumber(27);
            else if (input.Contains("spyware")) AnswerByNumber(28);
            else if (input.Contains("antivirus")) AnswerByNumber(29);
            else
            {
                TypeText("That’s a good question but I can’t answer it at the moment.");
                TypeText("Try a number (1–29) or type 'help'.");
            }
        }

        // ================= ANSWERS =================
        private void AnswerByNumber(int n)
        {
            switch (n)
            {
                case 1:
                    TypeText("I'm doing great and ready to help you stay safe online!");
                    break;

                case 2:
                    TypeText("My purpose is to teach cybersecurity and help protect users from online threats.");
                    break;

                case 3:
                    TypeText("Phishing is when attackers pretend to be trusted companies to steal your information.");
                    TypeText("Always verify emails and links before clicking.");
                    break;

                case 4:
                    TypeText("Strong passwords protect your accounts from hackers.");
                    TypeText("Use letters, numbers, symbols, and avoid personal details.");
                    TypeText("Example: T!ger@2026");
                    break;

                case 5:
                    TypeText("Malware is harmful software that damages or steals data.");
                    break;

                case 6:
                    TypeText("Ransomware locks your files and demands money to unlock them.");
                    break;

                case 7:
                    TypeText("Safe browsing means using HTTPS websites and avoiding suspicious links.");
                    break;

                case 8:
                    TypeText("Suspicious links can lead to fake websites designed to steal your data.");
                    break;

                case 9:
                    TypeText("Scams trick people into giving money or personal information.");
                    break;

                case 10:
                    TypeText("2FA adds extra security by requiring a second verification step.");
                    break;

                case 11:
                    TypeText("Cybersecurity protects your identity, money, and personal data.");
                    break;

                case 12:
                    TypeText("If hacked, change passwords, enable 2FA, and scan your device.");
                    break;

                case 13:
                    TypeText("Never share personal details like passwords or banking info.");
                    break;

                case 14:
                    TypeText("Social engineering tricks people into giving confidential information.");
                    break;

                case 15:
                    TypeText("A firewall protects your network from harmful traffic.");
                    break;

                case 16:
                    TypeText("A VPN encrypts your internet connection for privacy and safety.");
                    break;

                case 17:
                    TypeText("Identity theft is when someone steals your personal information.");
                    break;

                case 18:
                    TypeText("Use screen locks and trusted apps to protect your phone.");
                    break;

                case 19:
                    TypeText("Stay safe on social media by limiting what you share.");
                    break;

                case 20:
                    TypeText("Check website URLs and HTTPS to avoid fake sites.");
                    break;

                case 21:
                    TypeText("Cyberbullying is online harassment. Report and block offenders.");
                    break;

                case 22:
                    TypeText("Updating software is important because it fixes security issues and improves performance.");

                    TypeText("Windows:");
                    TypeText("Go to Settings → Windows Update → Check for updates.");

                    TypeText("Android:");
                    TypeText("Settings → Software Update → Download and Install.");

                    TypeText("iPhone:");
                    TypeText("Settings → General → Software Update → Install.");

                    TypeText("Apps:");
                    TypeText("Use Play Store/App Store → Update All apps.");

                    TypeText("Tip: Enable automatic updates for better security.");
                    break;

                case 23:
                    TypeText("Email attachments may contain viruses or malware.");
                    break;

                case 24:
                    TypeText("Use strong passwords and avoid public Wi-Fi for banking.");
                    break;

                case 25:
                    TypeText("Data privacy means protecting your personal information from misuse.");
                    break;

                case 26:
                    TypeText("Safe websites use HTTPS and look trustworthy.");
                    break;

                case 27:
                    TypeText("Students should avoid sharing passwords and suspicious links.");
                    break;

                case 28:
                    TypeText("Spyware secretly monitors your activity and steals data.");
                    break;

                case 29:
                    TypeText("Antivirus software detects and removes harmful programs.");
                    break;

                default:
                    TypeText("Please choose a number between 1 and 29.");
                    break;
            }
        }

        // ================= TYPING EFFECT =================
        private void TypeText(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Bot: ");
            Console.ResetColor();

            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(15);
            }

            Console.WriteLine();
        }
    }
}