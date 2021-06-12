using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyLove { 

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ILoveYou : ContentPage
    {
        Label compliment;
        Color fon;

        public ILoveYou()
        {
            //InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            fon = Color.FromHex("#f12b6b");

            BackgroundImageSource = "LoveFon.jpg";

            Frame title = new Frame
            {
                BackgroundColor = fon,
                Padding = 25,
                Content = new Label
                {
                    Text = $"Я люблю тебя, {Named()}",
                    TextColor = Color.Yellow,
                    FontSize = 24,
                    FontAttributes = FontAttributes.Bold,
                    HorizontalTextAlignment = TextAlignment.Center
                }
            };

            compliment = new Label
            {
                Text = $"{Compliment()}",
                TextColor = Color.Yellow,
                FontSize = 24,
                Padding = new Thickness(0, 10, 0, 10),
                Margin = new Thickness(5),
                HorizontalTextAlignment = TextAlignment.Center,
            };

            Frame compliments = new Frame
            {
                CornerRadius = 45,
                BackgroundColor = fon,
                Padding = new Thickness(0, 0, 0, 0),
                Margin = new Thickness(0, 50, 0, 0),
                BorderColor = Color.Black,
                Content = compliment
            };
            Button anothercompliment = new Button
            {
                Text = "Услышать ещё комплимент",
                BackgroundColor = fon,
                TextColor = Color.Yellow,
                FontAttributes = FontAttributes.Bold,
                CornerRadius = 20,
                BorderWidth = 1,
                BorderColor = Color.Black,
                Padding = new Thickness(0, 0, 0, 0),
                Margin = new Thickness(120, 0, 120, 50),
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };
            anothercompliment.Clicked += Anothercompliment_Clicked;

            Content = new StackLayout
            {
                Children = {
                    title,
                    compliments,
                    anothercompliment
                }
            };
        }
        private void Anothercompliment_Clicked(object sender, EventArgs e)
        {
            string newcompliment;
            while (true)
            {
                newcompliment = Compliment();
                if (compliment.Text != newcompliment) { break; }
            }
            compliment.Text = $"{newcompliment}";
        }

        public static string Compliment()
        {
            var compliments = new string[] {"Ты самый красивый и милый человек, которого я только встречал.",
                                            "На земле 7 миллиардов людей, а я люблю только тебя)",
                                            "Обожаю когда ты закидываешь на меня свои ножки;)" ,
                                            "Меня завораживают твои ямочки на щеках, когда ты улыбаешься." ,
                                            "Твои глаза и улыбка просто обворожительны." ,
                                            "Ты самая обаятельная и привлекательная девушка." ,
                                            "У тебя самые красивые глаза, скрывающие в себе какую-то тайну." ,
                                            "У тебя такой выразительный взгляд, что я чувствую твои прикосновения на расстоянии." ,
                                            "У тебя очень нежные губы." ,
                                            "Ты самая сексуальная девушка в мире." ,
                                            "В твои глаза невозможно не влюбиться." ,
                                            "Ты моё ласковое солнышко." ,
                                            "Ты меня улыбаешь(:" ,
                                            "Такое ощущение, что в твоих милых руках сосредоточена доброта: от твоих прикосновений становится тепло и уютно." ,
                                            "Ты всегда знаешь, как меня порадовать." ,
                                            "Если быть красивой считается преступлением, то тебя объявят виновной." ,
                                            "Я вижу столько тепла в твоих глазах." ,
                                            "Не переставай улыбаться, твоя улыбка обворожительна!" ,
                                            "Мне нравится твой стиль." ,
                                            "Одежда иделаьно сидит на тебе. Я ему даже завидую" ,
                                            "Ты очень вкусно пахнешь." ,
                                            "Твой смех очаровывает!" ,
                                            "Я очень сильно ценю тебя." ,
                                            "Ты прекрасный слушатель." ,
                                            "У тебя всегда самые лучшие идеи." ,
                                            "Твой голос очень мелодичный и волнующий." ,
                                            "Ты очень талантливая и креативная девушка" ,
                                            "Ты заслуживаешь объятия прямо сейчас." ,
                                            "Мне очень нравятся твои причуды." ,
                                            "С тобой мне всегда очень комфортно." ,
                                            "Мне нравится гулять с тобой." ,
                                            "Я благодарен за то, что ты есть." ,
                                            "Даже когда ты рядом, мне кажется, что тебя не хватает." ,
                                            "Ты понимаешь меня настолько хорошо, как будто читаешь мои мысли." ,
                                            "Просто проводить время с умной, красивой девушкой уже приносит незабываемые минуты радости." ,
                                            "Ты невероятна, когда не боишься быть собой." ,
                                            "Меня поражает твоя открытость и искренность." ,
                                            "У меня мурашки от тебя." ,
                                            "Ты как магнит притягиваешь к себе." ,
                                            "Вот смотрю на тебя и понимаю, что в человеке может быть прекрасна душа, тело и мысли." ,
                                            "Ты исполняешь песни в разы лучше их исполнители!" ,
                                            "Ты важна для меня" ,
                                            "Мне очень важно выслушать твое мнение" ,
                                            "Обожаю твои милые странности" ,
                                            "Всякий раз, когда мне грустно, мысль о тебе сразу поднимает настроение." ,
                                            "Ты даешь мне уверенность в себе и всегда меня поддерживаешь. Ты моя надежда и любовь." ,
                                            "Ты удивительная девушка, которая может служить примером для всех остальных." ,
                                            "Твой творческий потенциал кажется безграничным." ,
                                            "Ты очень хорошо готовишь." ,
                                            "Если бы я сейчас поехал в путешествие, то взял бы с собой только тебя."};
            var rand = new Random();
            int compliment = rand.Next(compliments.Length);
            return compliments[compliment];
        }

        public static string Named()
        {
            var names = new string[] { "Солнышко", "Милая", "Любимая", "Зайка", "Пиписечка)", "Кыця", "Киця",
                                        "Одуванчик" +
                                        "Моя сакура" +
                                        "Неповоримая" +
                                        "Принцесса" +
                                        "Красавица" +
                                        "Ангелочек" +
                                        "Дашенька" +
                                        "Дашуля" +
                                        "Милашка" +
                                        "Грустняшка" +
                                        "Симпатяжка" +
                                        "мой Сладкий Голосок" +
                                        "Маленькая" +
                                        "Малышка" +
                                        "Жопка моя" +
                                        "Злюка" +
                                        "Золотце" +
                                        "Счастье моё" +
                                        "Крошка;)", };

            var rand = new Random();
            int name = rand.Next(names.Length);
            return names[name];
        }
    }
}