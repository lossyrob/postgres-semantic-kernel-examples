using Microsoft.Extensions.VectorData;
using Microsoft.SemanticKernel.Data;

namespace SemanticKernelWithPostgres;

/// <summary>
/// Sample model class that represents a record entry.
/// </summary>
/// <remarks>
/// Note that each property is decorated with an attribute that specifies how the property should be treated by the vector store.
/// This allows us to create a collection in the vector store and upsert and retrieve instances of this class without any further configuration.
/// </remarks>
public sealed class ArxivRecord
{
    [VectorStoreRecordKey]
    [TextSearchResultName]
    public string Id { get; init; }

    [VectorStoreRecordData]
    public string Title { get; init; }

    [VectorStoreRecordData]
    [TextSearchResultValue]
    public string Abstract { get; init; }

    [VectorStoreRecordData]
    public DateTime Published { get; init; }

    [VectorStoreRecordData]
    public List<string> Authors { get; init; }

    [VectorStoreRecordData]
    public List<string> Categories { get; init; }

    [VectorStoreRecordData]
    [TextSearchResultLink]
    public string Link { get; init; }

    [VectorStoreRecordData]
    public string PdfLink { get; init; }

    [VectorStoreRecordVector(1536)]
    public ReadOnlyMemory<float>? Embedding { get; set; }
}
