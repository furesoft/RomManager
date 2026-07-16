# Contributing

Thanks for your interest in contributing to RomManager.
We welcome bug reports, feature ideas, documentation improvements, and pull requests.

## Table of Contents

1. Ways to Contribute
2. Before You Start
3. Development Setup
4. Branch and Commit Guidelines
5. Pull Request Process
6. Reporting Bugs
7. Feature Requests
8. Security
9. License

## Ways to Contribute

You can help by:

- Reporting bugs
- Suggesting new features
- Improving documentation
- Submitting code changes
- Reviewing pull requests

## Before You Start

Please:

- Check existing issues and pull requests to avoid duplicates
- Open an issue first for larger changes to align on scope
- Keep changes focused and small when possible

## Development Setup

### Prerequisites

- Git
- .NET SDK 10 or newer

### Clone and Build

1. Fork the repository
2. Clone your fork
3. Restore dependencies
4. Build the project

Suggested commands:

```bash
dotnet restore
dotnet build -c Release
```

If tests are available in your branch or future versions, run:

```bash
dotnet test
```

## Branch and Commit Guidelines

### Branch Naming

Use clear branch names, for example:

- feat/add-cover-art-cache
- fix/rename-dialog-crash
- docs/update-installation-guide
- chore/update-dependencies

### Commit Messages

Use [Conventional Commit](https://www.conventionalcommits.org/en/v1.0.0/) style:

- feat: add metadata cache for scraped covers
- fix: prevent null reference in rom scanner
- docs: update installation section
- chore: update CI dependencies

Keep commits small and meaningful.

## Pull Request Process

1. Create a pull request against the correct target branch
2. Describe what changed and why
3. Link related issues (for example: Closes #123)
4. Add screenshots or recordings for UI changes
5. Ensure build succeeds
6. Address review feedback promptly

### PR Checklist

- My change has a clear purpose
- I tested the change locally
- I updated docs where needed
- I kept the PR focused and minimal
- I followed commit and branch naming guidelines

## Reporting Bugs

When opening a bug report, include:

- Expected behavior
- Actual behavior
- Steps to reproduce
- OS and version
- App version or commit hash
- Logs or screenshots if relevant

## Feature Requests

For feature requests, include:

- Problem statement
- Proposed solution
- Alternatives considered
- Additional context or mockups

## Security

Please do not report security issues publicly.
Contact the maintainer privately first so the issue can be handled responsibly.

## License

By contributing, you agree that your contributions are licensed under the same license as this project (MIT).
