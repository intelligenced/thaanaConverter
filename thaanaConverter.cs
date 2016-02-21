public string ConvertThaanaToUnicode(string rawThaana)
        {
            String returnString = String.Empty;
            List<string> convertedListOfCharectersId = new List<string>();
            byte[] unicordBytesOfCharecters = Encoding.Unicode.GetBytes(rawThaana);
            for (int unicodeByteOfCharecter = unicordBytesOfCharecters.Length - 1; unicodeByteOfCharecter >= 0; unicodeByteOfCharecter--)
            {
                convertedListOfCharectersId.Add(unicordBytesOfCharecters[unicodeByteOfCharecter].ToString("X2"));
            }

            Dictionary<string, string> thaanaUnicodeMap = new Dictionary<string, string>
            {
                {"0780","h"},{"0781","S"},{"0782","n"},{"0783","r"},{"0784","b"},{"0785","L"},{"0786","k"},{"0787","a"},{"0788","v"},{"0789","m"},{"078A","f"},{"078B","d"},{"078C","t"},{"078D","l"},{"078E","g"},{"078F","N"},{"0790","s"},{"0791","D"},{"0792","z"},{"0793","T"},{"0794","y"},{"0795","p"},{"0796","j"},{"0797","C"},{"0798","X"},{"0799","H"},{"079A","K"},{"079B","J"},{"079C","R"},{"079D","x"},{"079E","B"},{"079F","F"},{"07A0","Y"},{"07A1","Z"},{"07A2","A"},{"07A3","G"},{"07A4","q"},{"07A5","V"},{"07A6","w"},{"07A7","W"},{"07A8","i"},{"07A9","I"},{"07AA","u"},{"07AB","U"},{"07AC","e"},{"07AD","E"},{"07AE","o"},{"07AF","O"},{"07B0","c"}
            };
            Dictionary<string, string> thaanaUnicodeMapMini = new Dictionary<string, string>
            {
                {"80","h"},{"81","S"},{"82","n"},{"83","r"},{"84","b"},{"85","L"},{"86","k"},{"87","a"},{"88","v"},{"89","m"},{"8A","f"},{"8B","d"},{"8C","t"},{"8D","l"},{"8E","g"},{"8F","N"},{"90","s"},{"91","D"},{"92","z"},{"93","T"},{"94","y"},{"95","p"},{"96","j"},{"97","C"},{"98","X"},{"99","H"},{"9A","K"},{"9B","J"},{"9C","R"},{"9D","x"},{"9E","B"},{"9F","F"},{"A0","Y"},{"A1","Z"},{"A2","A"},{"A3","G"},{"A4","q"},{"A5","V"},{"A6","w"},{"A7","W"},{"A8","i"},{"A9","I"},{"AA","u"},{"AB","U"},{"AC","e"},{"AD","E"},{"AE","o"},{"AF","O"},{"B0","c"}
            };

            foreach (string convertedId in convertedListOfCharectersId)
            {
                if (thaanaUnicodeMap.ContainsKey(convertedId))
                {
                    returnString += thaanaUnicodeMap[convertedId].ToString();
                }

                if (thaanaUnicodeMapMini.ContainsKey(convertedId))
                {
                    returnString += thaanaUnicodeMapMini[convertedId].ToString();
                }
            }

            return returnString;
        }