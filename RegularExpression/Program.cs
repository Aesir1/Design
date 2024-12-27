// See https://aka.ms/new-console-template for more information

using RegularExpression;

Console.WriteLine("Hello, World!");
SimpleRexegg simpleRexegg = new SimpleRexegg();
simpleRexegg.RexeggSimple();


TrainingRegex trainingRegex = new TrainingRegex();
trainingRegex.Match();
trainingRegex.Replace();
trainingRegex.CombineReplaceAndMatch(); 
trainingRegex.CombineMatchAndReplace();
trainingRegex.TestMatchNegativeLookBehind();
trainingRegex.ReplaceMappingOf();
trainingRegex.ReplaceMErrorWhileMapping();
trainingRegex.ReplaceDuplicateKey();
trainingRegex.ReplaceMultipleMappingOf();
trainingRegex.CheckPossibleId();
trainingRegex.CheckIdDateTimeAndKey();