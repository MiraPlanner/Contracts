using Sprint_Service.Models;

namespace Mira_Contracts.IssueContracts;

public record IssueCreated(
    Guid IssueId, 
    Guid? SprintId, 
    string Title, 
    IssueStatus IssueStatus,
    IssueType IssueType
);