using Sprint_Service.Models;

namespace Mira_Contracts.IssueContracts;

public record IssueUpdated(
    Guid IssueId, 
    Guid? SprintId, 
    string Title, 
    IssueStatus IssueStatus,
    IssueType IssueType
);