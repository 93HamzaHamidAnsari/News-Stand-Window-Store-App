using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;
using Windows.ApplicationModel.Search;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace News_Stand
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class fact : Page
    {
        Uri ui;
        public fact()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ui = e.Parameter as Uri;
        }

        
        //web view code ,web view accept uri link to display the content
        private async void open_web(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageDialog m = new MessageDialog("Please Wait for Loading Data Otherwise Check Your Internet");
                await m.ShowAsync();
                Uri uri = ui;
                web.Navigate(uri);
                web.Visibility = Visibility.Visible;
            }
            catch (Exception)
            {
                MessageDialog m = new MessageDialog("Solve Internet Problem For Reading News");
                m.ShowAsync();
            }
        }
        //end of web view
       

       //app bar code

        private void backs(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(news_stand));
        }

        private void homes(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(news_stand));
        }

        private void exits(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void nexts(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(global));
        }
        //end of app bar

        //coding for search pane
        private void MainPage_sugestionrequested(SearchPane sender, SearchPaneSuggestionsRequestedEventArgs args)
        {
            var listofsugestion = args.Request.SearchSuggestionCollection;
            if (listofsugestion.Size == 0)
            {
                if (args.QueryText.StartsWith("a", StringComparison.CurrentCultureIgnoreCase))
                {
                    listofsugestion.AppendQuerySuggestion("Americas");
                    listofsugestion.AppendQuerySuggestion("Asia");
                    listofsugestion.AppendQuerySuggestion("Africa");
                    listofsugestion.AppendQuerySuggestion("Articles");
                    listofsugestion.AppendQuerySuggestion("All Fashion");
                }
                else if (args.QueryText.StartsWith("b", StringComparison.CurrentCultureIgnoreCase))
                {
                    listofsugestion.AppendQuerySuggestion("Business Global");
                    listofsugestion.AppendQuerySuggestion("Business National");
                    listofsugestion.AppendQuerySuggestion("BBC Health");
                    listofsugestion.AppendQuerySuggestion("Basketball");
                    listofsugestion.AppendQuerySuggestion("Baseball");
                    listofsugestion.AppendQuerySuggestion("Beauty");
                }
                else if (args.QueryText.StartsWith("c", StringComparison.CurrentCultureIgnoreCase))
                {
                    listofsugestion.AppendQuerySuggestion("Cricket");
                    listofsugestion.AppendQuerySuggestion("Cricket Scores Live");
                }
                else if (args.QueryText.StartsWith("d", StringComparison.CurrentCultureIgnoreCase))
                {
                    listofsugestion.AppendQuerySuggestion("Dresses");

                }
                else if (args.QueryText.StartsWith("e", StringComparison.CurrentCultureIgnoreCase))
                {
                    listofsugestion.AppendQuerySuggestion("Education");
                    listofsugestion.AppendQuerySuggestion("Entertainment");
                    listofsugestion.AppendQuerySuggestion("Europe");

                }
                else if (args.QueryText.StartsWith("f", StringComparison.CurrentCultureIgnoreCase))
                {
                    listofsugestion.AppendQuerySuggestion("Facts About Pakistan");
                    listofsugestion.AppendQuerySuggestion("Football");
                    listofsugestion.AppendQuerySuggestion("Fashion");
                    listofsugestion.AppendQuerySuggestion("Footware");

                }
                else if (args.QueryText.StartsWith("g", StringComparison.CurrentCultureIgnoreCase))
                {
                    listofsugestion.AppendQuerySuggestion("Global News");
                    listofsugestion.AppendQuerySuggestion("Golf");
                }
                else if (args.QueryText.StartsWith("h", StringComparison.CurrentCultureIgnoreCase))
                {
                    listofsugestion.AppendQuerySuggestion("Health");
                    listofsugestion.AppendQuerySuggestion("Health:BBC");
                    listofsugestion.AppendQuerySuggestion("Health:The New York Times");
                    listofsugestion.AppendQuerySuggestion("Hockey");
                }
                else if (args.QueryText.StartsWith("i", StringComparison.CurrentCultureIgnoreCase))
                {
                    listofsugestion.AppendQuerySuggestion("Islamabad");

                }
                else if (args.QueryText.StartsWith("k", StringComparison.CurrentCultureIgnoreCase))
                {
                    listofsugestion.AppendQuerySuggestion("Karachi");

                }
                else if (args.QueryText.StartsWith("l", StringComparison.CurrentCultureIgnoreCase))
                {
                    listofsugestion.AppendQuerySuggestion("Lahore");
                    listofsugestion.AppendQuerySuggestion("Latest Global News");
                    listofsugestion.AppendQuerySuggestion("Latest National News");
                    listofsugestion.AppendQuerySuggestion("Latest Sports News");
                    listofsugestion.AppendQuerySuggestion("Latest Health News");
                    listofsugestion.AppendQuerySuggestion("Latest Education News");
                    listofsugestion.AppendQuerySuggestion("Latest Entertainment News");
                    listofsugestion.AppendQuerySuggestion("Latest Hair Styles");
                }
                else if (args.QueryText.StartsWith("m", StringComparison.CurrentCultureIgnoreCase))
                {
                    listofsugestion.AppendQuerySuggestion("MLB/Baseball");
                    listofsugestion.AppendQuerySuggestion("Motorsport");
                    listofsugestion.AppendQuerySuggestion("Movies");
                    listofsugestion.AppendQuerySuggestion("Movie News Hollywood");
                    listofsugestion.AppendQuerySuggestion("Movie News Bollywood");
                    listofsugestion.AppendQuerySuggestion("Movie Reviews Hollywood");
                    listofsugestion.AppendQuerySuggestion("Movie Reviews Bollywood");
                    listofsugestion.AppendQuerySuggestion("Movies Previews Bollywood");
                    listofsugestion.AppendQuerySuggestion("More Fashion");
                }
                else if (args.QueryText.StartsWith("n", StringComparison.CurrentCultureIgnoreCase))
                {
                    listofsugestion.AppendQuerySuggestion("National News");
                    listofsugestion.AppendQuerySuggestion("National News(All Cities)");
                    listofsugestion.AppendQuerySuggestion("NHL/Hockey");
                    listofsugestion.AppendQuerySuggestion("NBA/Basketball");
                    listofsugestion.AppendQuerySuggestion("New Movies Hollywood");
                    listofsugestion.AppendQuerySuggestion("New Movies Bollywood");

                }
                else if (args.QueryText.StartsWith("p", StringComparison.CurrentCultureIgnoreCase))
                {
                    listofsugestion.AppendQuerySuggestion("Peshawar");

                }
                else if (args.QueryText.StartsWith("r", StringComparison.CurrentCultureIgnoreCase))
                {
                    listofsugestion.AppendQuerySuggestion("Rugby League");
                    listofsugestion.AppendQuerySuggestion("Rugby Union");
                }
                else if (args.QueryText.StartsWith("s", StringComparison.CurrentCultureIgnoreCase))
                {
                    listofsugestion.AppendQuerySuggestion("Sports:ESPN/BBC");
                    listofsugestion.AppendQuerySuggestion("Soccer");
                    listofsugestion.AppendQuerySuggestion("Snooker");
                    listofsugestion.AppendQuerySuggestion("Sports:The News");
                    listofsugestion.AppendQuerySuggestion("Sports:BBC");
                    listofsugestion.AppendQuerySuggestion("Space & Science");
                    listofsugestion.AppendQuerySuggestion("Score Cricket:ESPN");
                }
                else if (args.QueryText.StartsWith("t", StringComparison.CurrentCultureIgnoreCase))
                {
                    listofsugestion.AppendQuerySuggestion("Top Stories(Global)");
                    listofsugestion.AppendQuerySuggestion("Top Stories of National");
                    listofsugestion.AppendQuerySuggestion("Top Stories of Sports");
                    listofsugestion.AppendQuerySuggestion("Top Stories of Health");
                    listofsugestion.AppendQuerySuggestion("Top Stories of Education");
                    listofsugestion.AppendQuerySuggestion("Top Stories of Hollywood");
                    listofsugestion.AppendQuerySuggestion("Top Stories of Bollywood");
                    listofsugestion.AppendQuerySuggestion("Top Stories of Science");
                    listofsugestion.AppendQuerySuggestion("Top Stories of Fashion");
                    listofsugestion.AppendQuerySuggestion("Technology");
                    listofsugestion.AppendQuerySuggestion("Tennis");
                    listofsugestion.AppendQuerySuggestion("The New York Times Health");

                }
                else if (args.QueryText.StartsWith("u", StringComparison.CurrentCultureIgnoreCase))
                {
                    listofsugestion.AppendQuerySuggestion("U.S");
                    listofsugestion.AppendQuerySuggestion("Upcoming Movies of Hollywood");
                    listofsugestion.AppendQuerySuggestion("Upcoming Movies of Bollywood");
                }
                else if (args.QueryText.StartsWith("w", StringComparison.CurrentCultureIgnoreCase))
                {
                    listofsugestion.AppendQuerySuggestion("World News");
                    listofsugestion.AppendQuerySuggestion("Weather News");
                }
            }
        }
        private void go(SearchPane sender, SearchPaneQuerySubmittedEventArgs args)
        {
            string s = args.QueryText;

            //Words Starts With 'A'.
            if (s == "Americas")
            {
                Uri america = new Uri("http://rss.cnn.com/rss/edition_americas.rss");
                this.Frame.Navigate(typeof(national_rss), america);

            }
            else if (s == "Asia")
            {
                Uri asia = new Uri("http://rss.cnn.com/rss/edition_asia.rss");
                this.Frame.Navigate(typeof(national_rss), asia);
            }

            else if (s == "Africa")
            {
                Uri africa = new Uri("http://rss.cnn.com/rss/edition_africa.rss");
                this.Frame.Navigate(typeof(national_rss), africa);
            }
            else if (s == "Articles")
            {
                Uri article = new Uri("http://feeds.feedburner.com/TheNewsInternational-Opinion");
                this.Frame.Navigate(typeof(national_rss), article);
            }
            else if (s == "All Fashion")
            {
                Uri latest = new Uri("http://feeds.glamour.com/glamour/all_fashion");
                this.Frame.Navigate(typeof(national_rss), latest);
            }
            //Words Starts With 'B'.
            else if (s == "Bussiness Global")
            {
                Uri buss = new Uri("	http://rss.cnn.com/rss/money_news_international.rss");
                this.Frame.Navigate(typeof(national_rss), buss);
            }

            else if (s == "Business National")
            {
                Uri bussiness = new Uri("http://feeds.feedburner.com/TheNewsInternational-Business");
                this.Frame.Navigate(typeof(national_rss), bussiness);
            }
            else if (s == "BBC Health")
            {
                Uri bbch = new Uri("http://feeds.bbci.co.uk/news/health/rss.xml?edition=int");
                this.Frame.Navigate(typeof(national_rss), bbch);
            }
            else if (s == "Basketball")
            {
                Uri nba = new Uri("http://sports.espn.go.com/espn/rss/nba/news");
                this.Frame.Navigate(typeof(national_rss), nba);
            }
            else if (s == "Baseball")
            {
                Uri mlb = new Uri("http://sports.espn.go.com/espn/rss/mlb/news");
                this.Frame.Navigate(typeof(national_rss), mlb);
            }
            else if (s == "Beauty")
            {
                Uri review = new Uri("http://www.allure.com/services/rss/feeds/everything.xml");
                this.Frame.Navigate(typeof(national_rss), review);
            }
            //Words Starts With 'C'.
            else if (s == "Cricket")
            {
                Uri cri = new Uri("http://www.espncricinfo.com/rss/content/story/feeds/0.xml");
                this.Frame.Navigate(typeof(national_rss), cri);
            }
            else if (s == "Cricket Scores Live")
            {
                Uri scorecard = new Uri("http://static.cricinfo.com/rss/livescores.xml");
                this.Frame.Navigate(typeof(national_rss), scorecard);
            }
            //Words Starts With 'D'.
            else if (s == "Dresses")
            {
                Uri dres = new Uri("http://www.fashiontrends.pk/dresses/salwar-kameez/");
                this.Frame.Navigate(typeof(fact), dres);
            }
            //Words Starts With 'E'.
            else if (s == "Education")
            {
                Uri edu = new Uri("http://www.ei-ie.org/en/rss/latestnews/en.rss");
                this.Frame.Navigate(typeof(national_rss), edu);
            }


            else if (s == "Entertainment")
            {
                this.Frame.Navigate(typeof(entertainment));
            }
            else if (s == "Europe")
            {
                Uri europe = new Uri("http://rss.cnn.com/rss/edition_europe.rss");
                this.Frame.Navigate(typeof(national_rss), europe);
            }
            //Words Starts With 'F'.
            else if (s == "Facts About Pakistan")
            {
                this.Frame.Navigate(typeof(fact));
            }

            else if (s == "Fashion")
            {
                this.Frame.Navigate(typeof(entertainment));
            }
            else if (s == "Football")
            {
                Uri soccer = new Uri("http://feeds.bbci.co.uk/sport/0/football/rss.xml?edition=uk");
                this.Frame.Navigate(typeof(national_rss), soccer);
            }
            else if (s == "Footware")
            {
                Uri footwar = new Uri("http://footwearnews.com/");
                this.Frame.Navigate(typeof(fact), footwar);
            }
            //Words Starts With 'G'.
            else if (s == "Global News")
            {
                this.Frame.Navigate(typeof(global));
            }

            else if (s == "Golf")
            {
                Uri golf = new Uri("http://feeds.bbci.co.uk/sport/0/golf/rss.xml?edition=uk");
                this.Frame.Navigate(typeof(national_rss), golf);
            }
            //Words Starts With 'H'.
            else if (s == "Health")
            {
                this.Frame.Navigate(typeof(health));
            }

            else if (s == "Health:BBC")
            {
                Uri bbch = new Uri("http://feeds.bbci.co.uk/news/health/rss.xml?edition=int");
                this.Frame.Navigate(typeof(national_rss), bbch);
            }
            else if (s == "Health:The New York Times")
            {
                Uri tnkh = new Uri("http://rss.nytimes.com/services/xml/rss/nyt/Research.xml");
                this.Frame.Navigate(typeof(national_rss), tnkh);
            }
            else if (s == "Hockey")
            {
                Uri nhl = new Uri("http://sports.espn.go.com/espn/rss/nhl/news");
                this.Frame.Navigate(typeof(national_rss), nhl);
            }
            else if (s == "Hair Styles New Trend")
            {
                Uri review = new Uri("http://www.haircutshairstyles.com/rss/trends.xml");
                this.Frame.Navigate(typeof(national_rss), review);
            }
            //Words Starts With 'I'.
            else if (s == "Islamabad")
            {
                Uri isl = new Uri("http://feeds.feedburner.com/TheNewsInternational-Islamabad");
                this.Frame.Navigate(typeof(national_rss), isl);
            }
            //Words Starts With 'K'.
            else if (s == "Karachi")
            {
                Uri karachi = new Uri("http://feeds.feedburner.com/TheNewsInternational-Karachi");
                this.Frame.Navigate(typeof(national_rss), karachi);
            }
            //Words Starts With 'L'.
            else if (s == "Lahore")
            {
                Uri lahore = new Uri("http://feeds.feedburner.com/TheNewsInternational-Lahore");
                this.Frame.Navigate(typeof(national_rss), lahore);
            }
            else if (s == "Latest Global News")
            {
                Uri us = new Uri("http://rss.cnn.com/rss/edition.rss");
                this.Frame.Navigate(typeof(national_rss), us);
            }
            else if (s == "Latest National News")
            {
                Uri top = new Uri("http://feeds.feedburner.com/com/cwEr");
                this.Frame.Navigate(typeof(national_rss), top);
            }
            else if (s == "Latest Sports News")
            {
                Uri sport = new Uri("http://feeds.feedburner.com/TheNewsInternational-Sports");
                this.Frame.Navigate(typeof(national_rss), sport);
            }
            else if (s == "Latest Health News")
            {
                this.Frame.Navigate(typeof(health));
            }
            else if (s == "Latest Entertainment News")
            {
                this.Frame.Navigate(typeof(entertainment));
            }
            else if (s == "Latest Education News")
            {
                Uri edu = new Uri("http://www.ei-ie.org/en/rss/latestnews/en.rss");
                this.Frame.Navigate(typeof(national_rss), edu);
            }
            else if (s == "Latest Hair Styles")
            {
                Uri review = new Uri("http://www.haircutshairstyles.com/rss/trends.xml");
                this.Frame.Navigate(typeof(national_rss), review);
            }
            //Words Starts With 'M'.
            else if (s == "MLB/Baseball")
            {
                Uri mlb = new Uri("http://sports.espn.go.com/espn/rss/mlb/news");
                this.Frame.Navigate(typeof(national_rss), mlb);
            }
            else if (s == "Motorsport")
            {
                Uri motor = new Uri("http://sports.espn.go.com/espn/rss/rpm/news");
                this.Frame.Navigate(typeof(national_rss), motor);
            }
            else if (s == "Movies")
            {
                this.Frame.Navigate(typeof(entertainment));
            }
            else if (s == "Movie News Hollywood")
            {
                Uri top = new Uri("http://rss.cnn.com/rss/edition_entertainment.rss");
                this.Frame.Navigate(typeof(national_rss), top);
            }
            else if (s == "Movie Reviews Hollywood")
            {
                Uri review = new Uri("http://www.cinemablend.com/rss_review.php");
                this.Frame.Navigate(typeof(national_rss), review);
            }
            else if (s == "Movie News Bollywood")
            {
                Uri top = new Uri("http://www.bollywoodhungama.com/rss/news.xml");
                this.Frame.Navigate(typeof(national_rss), top);
            }
            else if (s == "Movies Previews Bollywood")
            {
                Uri latest = new Uri("http://www.bollywoodhungama.com/rss/movie_previews.xml");
                this.Frame.Navigate(typeof(national_rss), latest);
            }
            else if (s == "Movie Reviews Bollywood")
            {
                Uri review = new Uri("http://www.bollywoodhungama.com/rss/movie_reviews.xml");
                this.Frame.Navigate(typeof(national_rss), review);
            }
            else if (s == "More Fashion")
            {
                Uri review = new Uri("http://www.justluxe.com/rss/rss-channels.php?sec=fineliving");
                this.Frame.Navigate(typeof(national_rss), review);
            }
            //Words Starts With 'N'.

            else if (s == "NHL/Hockey")
            {
                Uri nhl = new Uri("http://sports.espn.go.com/espn/rss/nhl/news");
                this.Frame.Navigate(typeof(national_rss), nhl);
            }
            else if (s == "NBA/Basketball")
            {
                Uri nba = new Uri("http://sports.espn.go.com/espn/rss/nba/news");
                this.Frame.Navigate(typeof(national_rss), nba);
            }
            else if (s == "New Movies Hollywood")
            {
                Uri coming = new Uri("http://www.cinemablend.com/rss_preview.php");
                this.Frame.Navigate(typeof(national_rss), coming);
            }
            else if (s == "New Movies Bollywood")
            {
                Uri coming = new Uri("http://www.bollywoodhungama.com/rss/release_dates.xml");
                this.Frame.Navigate(typeof(national_rss), coming);
            }
            else if (s == "National News")
            {
                this.Frame.Navigate(typeof(national));
            }
            else if (s == "National News(All Cities)")
            {
                Uri national = new Uri("http://feeds.feedburner.com/TheNewsInternational-National");
                this.Frame.Navigate(typeof(national_rss), national);
            }
            //Words Starts With 'P'.
            else if (s == "Peshawar")
            {
                Uri peshawar = new Uri("http://feeds.feedburner.com/TheNewsInternational-Peshawar");
                this.Frame.Navigate(typeof(national_rss), peshawar);
            }
            //Words Starts With 'R'.
            else if (s == "Rugby League")
            {
                Uri rl = new Uri("http://feeds.bbci.co.uk/sport/0/rugby-league/rss.xml?edition=uk");
                this.Frame.Navigate(typeof(national_rss), rl);
            }
            else if (s == "Rugby Union")
            {
                Uri ru = new Uri("http://feeds.bbci.co.uk/sport/0/rugby-union/rss.xml?edition=uk");
                this.Frame.Navigate(typeof(national_rss), ru);
            }
            //Words Starts With 'S'.

            else if (s == "Sports:ESPN/BBC")
            {
                this.Frame.Navigate(typeof(sports));
            }
            else if (s == "Soccer")
            {
                Uri soccer = new Uri("http://feeds.bbci.co.uk/sport/0/football/rss.xml?edition=uk");
                this.Frame.Navigate(typeof(national_rss), soccer);
            }
            else if (s == "Snooker")
            {
                Uri snooker = new Uri("http://feeds.bbci.co.uk/sport/0/snooker/rss.xml?edition=uk");
                this.Frame.Navigate(typeof(national_rss), snooker);
            }
            else if (s == "Space & Science")
            {
                Uri space = new Uri("http://rss.cnn.com/rss/edition_space.rss");
                this.Frame.Navigate(typeof(national_rss), space);
            }
            else if (s == "Sports:BBC")
            {
                Uri sports = new Uri("http://feeds.bbci.co.uk/sport/0/rss.xml?edition=uk");
                this.Frame.Navigate(typeof(national_rss), sports);
            }
            else if (s == "Sports:The News")
            {
                Uri sport = new Uri("http://feeds.feedburner.com/TheNewsInternational-Sports");
                this.Frame.Navigate(typeof(national_rss), sport);
            }
            //Words Starts With 'T'.

            else if (s == "Top Stories(Global)")
            {
                Uri us = new Uri("http://rss.cnn.com/rss/edition.rss");
                this.Frame.Navigate(typeof(national_rss), us);
            }
            else if (s == "Top Stories of National")
            {
                Uri top = new Uri("http://feeds.feedburner.com/com/cwEr");
                this.Frame.Navigate(typeof(national_rss), top);
            }
            else if (s == "Top Stories of Sports")
            {
                Uri sports = new Uri("http://feeds.bbci.co.uk/sport/0/rss.xml?edition=uk");
                this.Frame.Navigate(typeof(national_rss), sports);
            }
            else if (s == "Top Stories of Science")
            {
                Uri space = new Uri("http://rss.cnn.com/rss/edition_space.rss");
                this.Frame.Navigate(typeof(national_rss), space);
            }
            else if (s == "Top Stories of Health")
            {
                this.Frame.Navigate(typeof(health));
            }
            else if (s == "Top Stories of Hollywood")
            {
                Uri top = new Uri("http://rss.cnn.com/rss/edition_entertainment.rss");
                this.Frame.Navigate(typeof(national_rss), top);
            }
            else if (s == "Top Stories of Bollywood")
            {
                Uri top = new Uri("http://www.bollywoodhungama.com/rss/news.xml");
                this.Frame.Navigate(typeof(national_rss), top);
            }
            else if (s == "Top Stories of Education")
            {
                Uri edu = new Uri("http://www.ei-ie.org/en/rss/latestnews/en.rss");
                this.Frame.Navigate(typeof(national_rss), edu);
            }
            else if (s == "Top Stories of Fashion")
            {
                Uri top = new Uri("http://www.elle.com/rss/fashion.xml");
                this.Frame.Navigate(typeof(national_rss), top);
            }
            else if (s == "Tennis")
            {
                Uri tenni = new Uri("http://feeds.bbci.co.uk/sport/0/tennis/rss.xml?edition=uk");
                this.Frame.Navigate(typeof(national_rss), tenni);
            }
            else if (s == "Technology")
            {
                Uri tech = new Uri("http://rss.cnn.com/rss/edition_technology.rss");
                this.Frame.Navigate(typeof(national_rss), tech);
            }
            else if (s == "The New York Times Health")
            {
                Uri tnkh = new Uri("http://rss.nytimes.com/services/xml/rss/nyt/Research.xml");
                this.Frame.Navigate(typeof(national_rss), tnkh);
            }
            //Words Starts With 'U'.

            else if (s == "U.S")
            {
                Uri us = new Uri("http://rss.cnn.com/rss/edition_us.rss");
                this.Frame.Navigate(typeof(national_rss), us);
            }
            else if (s == "Upcoming Movies of Hollywood")
            {
                Uri coming = new Uri("http://www.cinemablend.com/rss_preview.php");
                this.Frame.Navigate(typeof(national_rss), coming);
            }
            else if (s == "Upcoming Movies of Bollywood")
            {
                Uri coming = new Uri("http://www.bollywoodhungama.com/rss/release_dates.xml");
                this.Frame.Navigate(typeof(national_rss), coming);
            }
            //Words Starts With 'W'.
            else if (s == "World")
            {
                Uri world = new Uri("http://rss.cnn.com/rss/edition_world.rss");
                this.Frame.Navigate(typeof(national_rss), world);
            }
            else if (s == "Weather News")
            {
                this.Frame.Navigate(typeof(weather));
            }
        }

        private void searching(object sender, PointerRoutedEventArgs e)
        {
            SearchPane.GetForCurrentView().SuggestionsRequested += MainPage_sugestionrequested;
            SearchPane.GetForCurrentView().QuerySubmitted += go;
            SearchPane.GetForCurrentView().Show();
        }




        //end of search pane  
    }
}
