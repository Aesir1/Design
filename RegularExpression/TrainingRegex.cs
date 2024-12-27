using System.Text.RegularExpressions;

namespace RegularExpression;

public class TrainingRegex
{
    public void Match()
    {
        string input = "Mapping of Consol failed. ExternalIdentifiers: 'C02792239'\r\n" +
                       "The instance of entity type 'PublicHoliday' cannot be tracked because another instance with the key value '{Id: e7c19c4d-62ca-4f1f-9258-08dc36e76d7c}' is already being tracked. When attaching existing entities, ensure that only one entity instance with a given key value is attached.";

        // Define the regex pattern
        string pattern = @"^(?!.*\bMapping of \w+).*";
        //string pattern = @"^(?!.*\bMapping of \w+)(?!\w{8}-\w{4}-\w{4}-\w{4}-\w{12}).*";
        

        // Create the regex object
        Regex regex = new Regex(pattern, RegexOptions.Multiline);

        // List to store the extracted values
        List<string> extractedValues = new List<string>();

        // Find all matches
        MatchCollection matches = regex.Matches(input);

        // Iterate through matches
        foreach (Match match in matches)
        {
            // Add the matched value to the list
            extractedValues.Add(match.Value);
        }

        // Display the extracted values
        Console.WriteLine("Extracted Values:");
        foreach (string value in extractedValues)
        {
            Console.WriteLine(value);
        }

        Console.ReadKey();
    }
    
    
    public void Replace()
    {
        string input = "Mapping of Consol failed. ExternalIdentifiers: 'C02792239'\r\n" +
                       "The instance of entity type 'PublicHoliday' cannot be tracked because another instance with the key value '{Id: e7c19c4d-62ca-4f1f-9258-08dc36e76d7c}' is already being tracked. When attaching existing entities, ensure that only one entity instance with a given key value is attached.";

        // Define the regex pattern
        string pattern = @"\b\w*[0-9\-_+]\w*";
        //string pattern = @"\b\w{8}-\w{4}-\w{4}-\w{4}-\w{12}\b";

        // List to store the extracted values
        List<string> extractedValues = new List<string>();

        // Find all matches
        
        // Add the matched value to the list
        extractedValues.Add(Regex.Replace(input, pattern, ""));
        

        // Display the extracted values
        Console.WriteLine("Extracted Values:");
        foreach (string value in extractedValues)
        {
            Console.WriteLine(value);
        }

        Console.ReadKey();
    }

    public void CombineReplaceAndMatch()
    {
        string input = "Mapping of Consol failed. ExternalIdentifiers: 'C02792239'\r\n" +
                       "The instance of entity type 'PublicHoliday' cannot be tracked because another instance with the key value '{Id: e7c19c4d-62ca-4f1f-9258-08dc36e76d7c}' is already being tracked. When attaching existing entities, ensure that only one entity instance with a given key value is attached.";
        
        
        string findAllPossibleIdentifier = @"\b\w*[0-9\-_+]+\w*";
        string pattern = @"^(?!.*\bMapping of \w+).*";
        
        
        // List to store the extracted values
        List<string> extractedValues = new List<string>();
        
        //Replace ids with ""
        var withoutIds = Regex.Replace(input, findAllPossibleIdentifier, "");
        
        // Find all matches
        Regex regex = new Regex(pattern);
        Match match = regex.Match(withoutIds);
        
        // Add the matched value to the list
        extractedValues.Add(match.Value);
        
        // Display the extracted values
        Console.WriteLine("CombineReplaceAndMatch:");
        foreach (string value in extractedValues)
        {
            Console.WriteLine(value);
        }
        
        Console.ReadKey();
        
    }
    
    public void CombineMatchAndReplace()
    {
        string input = @"Mapping of Consol failed. ExternalIdentifiers: 'C02792239'
The instance of entity type 'PublicHoliday' cannot be tracked because another instance with the key value '{Id: e7c19c4d-62ca-4f1f-9258-08dc36e76d7c}' is already being tracked. When attaching existing entities, ensure that only one entity instance with a given key value is attached.";
        
        
        string findAllPossibleIdentifier = @"\b\w*[0-9\-_+]+\w*";
        string pattern = @"^(?!.*\bMapping of \w+).*";
        
        
        // List to store the extracted values
        List<string> extractedValues = new List<string>();
        
        // Find all matches
        Regex regex = new Regex(pattern);
        Match match = regex.Match(input);
        
        //Replace ids with ""
        var withoutIds = Regex.Replace(match.Value, findAllPossibleIdentifier, "");
        
        // Add the matched value to the list
        extractedValues.Add(withoutIds);
        
        // Display the extracted values
        Console.WriteLine("CombineMatchAndReplace:");
        foreach (string value in extractedValues)
        {
            Console.WriteLine(value);
        }
        
        Console.ReadKey();
        
    }


    public void TestMatchNegativeLookBehind()
    {
        string input = "Mapping of Consol failed. ExternalIdentifiers: ''\rThe instance of entity type 'PublicHoliday' cannot be tracked because another instance with the key value '{Id: }' is already being tracked. When attaching existing entities, ensure that only one entity instance with a given key value is attached.";

        // Define the regex pattern
        string pattern = @"^(?!.*\bMapping of \w+).*";
        //string pattern = @"^(?!.*\bMapping of \w+)(?!\w{8}-\w{4}-\w{4}-\w{4}-\w{12}).*";
        

        // Create the regex object
        Regex regex = new Regex(pattern, RegexOptions.Multiline);

        // List to store the extracted values
        List<string> extractedValues = new List<string>();

        // Find all matches
        MatchCollection matches = regex.Matches(input);

        // Iterate through matches
        foreach (Match match in matches)
        {
            // Add the matched value to the list
            extractedValues.Add(match.Value);
        }

        // Display the extracted values
        Console.WriteLine("Extracted Values:");
        foreach (string value in extractedValues)
        {
            Console.WriteLine(value);
        }

        Console.ReadKey();
    }

    public void ReplaceMappingOf()
    {
        string input = @"Mapping of Consol failed. ExternalIdentifiers: 'C02792239'
The instance of entity type 'PublicHoliday' cannot be tracked because another instance with the key value '{Id: e7c19c4d-62ca-4f1f-9258-08dc36e76d7c}' is already being tracked. When attaching existing entities, ensure that only one entity instance with a given key value is attached.";


        // Define the regex pattern
        //string pattern = @".*\bMapping of\b.*";
        //string replaceId = @"\b\w*[0-9\-_+]+\w*";
        string pattern = @".*\bMapping of \w+.*";
        string replaceId = @"\b\w{8}-\w{4}-\w{4}-\w{4}-\w{12}\b";
        

        // Create the regex object
        

        // List to store the extracted values
        List<string> extractedValues = new List<string>();

        var newValues = Regex.Replace(input, pattern, "");
        var endResult = Regex.Replace(newValues, replaceId, "");

        // Display the extracted values
        Console.WriteLine("Extracted Values:");
        Console.WriteLine(endResult);

        Console.ReadKey();
    }
    
    
    
    
    public void ReplaceMErrorWhileMapping()
    {
        string input = "Error while mapping Invoice 707405052.\nAn item with the same key has already been added. Key: (USD, 03/19/2024 00:00:00)";

        // Define the regex pattern
        //string pattern = @".*\bMapping of\b.*";
        //string replaceId = @"\b\w*[0-9\-_+]+\w*";
        string pattern = @".*\bMapping of \w+.*";
        string replaceId = @"\b\w{8}-\w{4}-\w{4}-\w{4}-\w{12}\b";
        string replaceErrorByMappingId = @"^Error while mapping \w+\s+(.*)";
        

        var newValues = Regex.Replace(input, pattern, "");
        var withoutErrorWhilemappingId = Regex.Replace(newValues, replaceErrorByMappingId, "");
        var endResult = Regex.Replace(withoutErrorWhilemappingId, replaceId, "");

        // Display the extracted values
        Console.WriteLine("Extracted Values:");
        Console.WriteLine(endResult);
        
        string inputString = "Error while mapping Invoice 707405052.\nAn item with the same key has already been added. Key: (USD, 03/19/2024 00:00:00)";
        string pattern2 = @"\b\w*[0-9\-_+]+\w*";
        string outputString = Regex.Replace(inputString, pattern2, "");
        
        Console.WriteLine(outputString);

        Console.ReadKey();
    }
    
    
    public void ReplaceDuplicateKey()
    {
        string input = @"An error occurred while saving the entity changes. See the inner exception for details.\nCannot insert duplicate key row in object 'dbo.ExternalAddressIdentifiers' with unique index ''. The duplicate key value is (.MAZARREDO,   DPT, ).\nThe statement has been terminated.";

        // regex patterns
        var replaceId = @"\b\w{8}-\w{4}-\w{4}-\w{4}-\w{12}\b";
        var replaceMappingOf = @".*\bMapping of \w+.*";
        var matchDupicateKey = @"The duplicate key value is \(.*";
        var replaceNumberAndLetter = @"\b\w*[0-9\-_+]+\w*";
        

        string removedGuids = Regex.Replace(input, replaceId, "");
        string withoutMappingOf = Regex.Replace(removedGuids, replaceMappingOf, "");
        string withoutKeyDuplicate =  Regex.Replace(withoutMappingOf, matchDupicateKey, "");
        string errorEssence = Regex.Replace(withoutKeyDuplicate, replaceNumberAndLetter, "");

        // Display the extracted values
        Console.WriteLine("Extracted Values:");
        Console.WriteLine(errorEssence);

        Console.ReadKey();
    }
    
    public void ReplaceMultipleMappingOf()
    {
        string input = @"Mapping of Shipment failed. ExternalIdentifiers: 'S04273507' Id: 'a31cf159-92c7-4c99-90fd-08dc43c87776'\nMapping of Consol failed. ExternalIdentifiers: 'C02798467' Id: 'cb86596e-9054-47a4-b062-08dc4833db0d'\nNo file found for ConsolBlobStorageFileReferenceProxy with identifier C02798467.";

        //language=regex
        var replaceId = @"\b\w{8}-\w{4}-\w{4}-\w{4}-\w{12}\b";
        var replaceMappingOf = @".*\bMapping of \w+.*[\n\r]+";
        var matchDupicateKey = @"The duplicate key value is \(.*\)";
        var replaceNumberAndLetter = @"\b\w*[0-9\-_+]+\w*";
        

        string removedGuids = Regex.Replace(input, replaceId, "ID");
        string withoutMappingOf = Regex.Replace(removedGuids, replaceMappingOf, "");
        string withoutKeyDuplicate =  Regex.Replace(withoutMappingOf, matchDupicateKey, "The duplicate key value is {ID}");
        string errorEssence = Regex.Replace(withoutKeyDuplicate, replaceNumberAndLetter, "");

        // Display the extracted values
        Console.WriteLine("Extracted Values:");
        Console.WriteLine(errorEssence);

        Console.ReadKey();
    }


    public void CheckPossibleId()
    {
        List<string> inputs = new List<string>()
        {
            @"A severe error occurred on the current command.  The results, if any, should be discarded.
A severe error occurred on the current command.  The results, if any, should be discarded.",
            @"A transport-level error has occurred when receiving results from the server. (provider: TCP Provider, error: 35 - An internal exception was caught)
Unable to read data from the transport connection: Connection reset by peer.
Connection reset by peer",
            @"An error occurred while saving the entity changes. See the inner exception for details.
A transport-level error has occurred when receiving results from the server. (provider: TCP Provider, error: 35 - An internal exception was caught)
Unable to read data from the transport connection: Connection reset by peer.
Connection reset by peer",
            @"address.Code cannot be null or empty",
            @"",
            @"",
            @"",
            @"",
            @"",
            @"",
            @"",
            @"",
            @"",
            @"",
            @"",
            @"",
            @"",
            @"",
            @"",
            @"",
            @"",
            @"",
            @"",
            @"",
            @""
        };
        var replaceNumberAndLetter = @"\b\w*[0-9\-_+]+\w*";
        Regex regex = new Regex(replaceNumberAndLetter, RegexOptions.Compiled);
        int counter = 0;
        foreach (string input in inputs)
        {
            Console.WriteLine($"Nr: {counter++} +  {regex.Replace(input, "Ö")}");
        }
    }

    public void CheckIdDateTimeAndKey()
    {
        List<string> inputs = new List<string>()
        {
            "An item with the same key has already been added. Key: (USD, DD/MM/YYYY HH:MM:SS)",
            "An error occurred while saving the entity changes. See the inner exception for details.\nCannot insert duplicate key row in object 'dbo.ExternalAddressIdentifiers' with unique index 'IX_ExternalAddressIdentifiers_Identifier_CargonerdsCustomerId'. The duplicate key value is {ID}\nThe statement has {ID}been terminated.",
            "The database operation was expected to affect 1 row(s), but actually affected 0 row(s); data may have been modified or deleted since entities were loaded. See http://go.microsoft.com/fwlink/?LinkId=527962 for information on understanding and handling optimistic concurrency exceptions.",
            "No file found for ShipmentBlobStorageFileReferenceProxy with identifier  {ID}",
            "An error occurred while saving the entity changes. See the inner exception for details.\nCannot insert duplicate key row in object 'dbo.ExternalContactIdentifiers' with unique index 'IX_ExternalContactIdentifiers_Identifier_CargonerdsCustomerId'. The duplicate key value is {ID}\nThe statement has been terminated.",
            "Cache does not contain TEST with key {KEY}",
            ""
        };

        foreach (string input in inputs)
        {
            //Console.WriteLine(Regex.Replace(input, pattern:@"\(USD, DD/MM/YYYY HH:MM:SS\)*", "%"));  
            Console.WriteLine(Regex.Replace(input, @"\{ID\}|DD/MM/YYYY HH:MM:SS|\{KEY\}*", "%"));
        }

        Console.ReadKey();
    }
}