// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.EntityFrameworkCore.Metadata;

namespace EntityFrameworkCore.Jet.Metadata
{
    public interface IJetModelAnnotations : IRelationalModelAnnotations
    {
        JetValueGenerationStrategy? ValueGenerationStrategy { get; }
        string HiLoSequenceName { get; }
        string HiLoSequenceSchema { get; }
    }
}
