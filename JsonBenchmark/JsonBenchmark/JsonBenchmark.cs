using BenchmarkDotNet.Attributes;

namespace JsonBenchmark
{
    public record JsonData(
    string Description,
    string Location,
    string? DatabankName,
    string ScaleFactor,
    string AuthorEmail,
    string Author,
    string? AuthorTelephone,
    int HistoricalEndYear,
    int HistoricalEndQuarter,
    int? ImposedEndYear,
    int? ImposedEndQuarter,
    string BaseYearPrice,
    string LastUpdate,
    bool SeasonallyAdjusted,
    string SectorCoverage,
    string BaseYearIndex,
    string SourceDetails,
    string Units,
    string Source,
    string AdditionalSourceDetails,
    string MeasureName,
    string AnnualTypeCode,
    string AnnualisationType,
    string PartnerName,
    string IndicatorName,
    string ScenarioName,
    string CommodityName,
    string MarketSectorName,
    string IncomeBandName,
    bool HasQuarterly,
    string CategoryDescription,
    string AlternateScaleFactor,
    string AlternateUnits
);

    [MemoryDiagnoser]
    public class JsonBenchmarker
    {
        private string metadataJson = "{\"Description\":\"Electrical, optical & high-tech, Investment, real LCU\",\"Location\":\"United Kingdom\",\"DatabankName\":null,\"ScaleFactor\":\"Billions: 2015 prices\",\"AuthorEmail\":\"asamp@oxfordeconomics.com\",\"Author\":\"Abby Samp\",\"AuthorTelephone\":null,\"HistoricalEndYear\":2022,\"HistoricalEndQuarter\":2,\"ImposedEndYear\":null,\"ImposedEndQuarter\":null,\"BaseYearPrice\":\"2015\",\"LastUpdate\":\"04 June 2021\",\"SeasonallyAdjusted\":true,\"SectorCoverage\":\"Electrical, optical & high-tech, NACE rv2 26,27\",\"BaseYearIndex\":\"\",\"SourceDetails\":\"Investment Electrical, optical & high-tech rebased to 2015 prices\",\"Units\":\"Pound\",\"Source\":\"Office for National Statistics/Haver Analytics\",\"AdditionalSourceDetails\":\"\",\"MeasureName\":\"Level\",\"AnnualTypeCode\":\"\",\"AnnualisationType\":\"T\",\"PartnerName\":\"\",\"IndicatorName\":\"Electrical, optical & high-tech, Investment, real LCU\",\"ScenarioName\":\"Investment, real LCU\",\"CommodityName\":\"\",\"MarketSectorName\":\"\",\"IncomeBandName\":\"\",\"HasQuarterly\":true,\"CategoryDescription\":\"\",\"AlternateScaleFactor\":\"Billions\",\"AlternateUnits\":\"Pound\"}";

        [Benchmark(Baseline = true)]
        public void NewtonsoftJson()
        {
            _ = Newtonsoft.Json.JsonConvert.DeserializeObject<JsonData>(metadataJson);
        }

        [Benchmark]
        public void SystemTextJson()
        {
            _ = System.Text.Json.JsonSerializer.Deserialize<JsonData>(metadataJson);
        }
    }
}
