## Postgres and .NET Semantic Kernel Examples

TODO

Copy the `appsettings.json.example` file to `appsettings.json` and fill in the connection string for your PostgreSQL database, or keep the
existing one if using the provided `docker-compose.yml` file. You must provide Azure OpenAI details for an instance with
text embedding and chat completion models deployed.

```
> cd dotnet
> dotnet restore
> dotnet build
> dotnet run load --topic RAG --total 100
> dotnet run query "What are good chunking strategies to use for unstructured text in RAG applications?"
```

Example output, loaded ~600 RAG-related papers:

```markdown
Here's a list of strategies and insights about chunking for unstructured text, derived from recent research articles:

### Recommended Chunking Strategies for RAG Applications

1. **Recursive Character Splitting** -
   The Recursive Character Splitter is shown to outperform Token-based Splitters in preserving contextual integrity during document splitting. This method is particularly effective for maintaining the coherence and capturing the meaning essential for retrieval tasks. [Paper: [Exploring Information Retrieval Landscapes](http://arxiv.org/abs/2409.08479v2)]

2. **Node-based Extraction** -
   For documents with highly diverse structures, employing node-based extraction with LLM-powered Optical Character Recognition (OCR) improves chunking by creating context-aware relationships between text components (e.g., headers and sections). This is crucial for multimodal documents like presentations and scanned files. [Paper: [Advanced ingestion process powered by LLM parsing](http://arxiv.org/abs/2412.15262v1)]

3. **Inference-time Hybrid Structuring** -
   Structured reconstruction of documents is advocated to handle knowledge-intensive tasks better. This involves optimizing the document format for task-specific structuring using "StructRAG" frameworks, which determine the optimal chunk size and type for retrieving relevant information accurately. [Paper: [StructRAG: Boosting Knowledge Intensive Reasoning](http://arxiv.org/abs/2410.08815v2)]

4. **Interpretable Knowledge Segmentation** -
   Chunking HTML or unstructured text into meaningful units for specific downstream tasks can be enhanced by pre-trained models combined with algorithms for efficient segmentation. This improves HTML or table data understanding and retrieval from unstructured text. [Paper: [Leveraging Large Language Models for Web Scraping](http://arxiv.org/abs/2406.08246v1)]

5. **Benchmark-Driven Optimization** -
   Use domain-specific benchmarks (e.g., UDA Suite) to evaluate and optimize chunking and retrieval methods. Real-world applications, involving lengthy or noisy documents in diverse formats, benefit from such approaches to balance character and word-level chunking boundaries. [Paper: [UDA: A Benchmark Suite for RAG](http://arxiv.org/abs/2406.15187v2)]

### Practical Suggestions:

- **Context Preservation with Overlap**: Introducing a degree of overlap between adjacent chunks ensures preserved meaning and continuity.

- **Multimodal Parsing**: Different parsing strategies for highly unstructured data types improve the granularity of retrieval strategies (i.e., PDFs, presentations).

- **Evaluation Metrics**: Incorporating advanced evaluation techniques like SequenceMatcher, BLEU, METEOR, and BERT Score can guide chunking methodology tailoring for retrieval accuracy.

Would you like a deep dive into any of the specific papers or methods listed above?
```