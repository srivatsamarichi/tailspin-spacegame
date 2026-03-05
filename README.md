# Technical details for TailspinSpace Game

## 🧪 Code Quality

| Tool | Status |
|------|--------|
| Codacy | [![Codacy Badge](https://api.codacy.com/project/badge/Grade/1315e116650345da9177b96c327f7901)](https://app.codacy.com/manual/srivatsams/tailspin-spacegame-web?utm_source=github.com&utm_medium=referral&utm_content=srivatsamarichi/tailspin-spacegame-web&utm_campaign=Badge_Grade_Dashboard) |
| SonarCloud Quality Gate | [![SonarQuality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=srivatsamarichi_tailspin-spacegame&metric=alert_status)](https://sonarcloud.io/dashboard?id=srivatsamarichi_tailspin-spacegame) |

### ⚙️ CI / Build Pipelines

| Workflow | Status |
|----------|--------|
| Lint Code Base | ![Lint Code Base](https://github.com/srivatsamarichi/tailspin-spacegame/workflows/Lint%20Code%20Base/badge.svg) |
| Spacegame.Web dotnet | ![Spacegame.Web](https://github.com/srivatsamarichi/tailspin-spacegame-web/workflows/Spacegame.Web/badge.svg) |
| Spacegame.Web Docker | ![Spacegame.Web.Docker](https://github.com/srivatsamarichi/tailspin-spacegame-web/workflows/Spacegame.Web.Docker/badge.svg) |

### 🚀 Deployment

| Platform | Status |
|----------|--------|
| Azure App Service | ![Azure App Service](https://vsrm.dev.azure.com/rubdevopson/_apis/public/Release/badge/c53ed56f-c130-470b-a6ae-3c4a93266530/36/91) |

## Overview

Tailspin Toys, or Tailspin for short, is a video game company. Tailspin hosts its game servers and websites in an on-premises data-center. The company just celebrated the release of a new racing game. They'll be releasing a space shooter game, called Space Game, in the coming months.

The team builds websites to support new game titles. These websites provide information about the game, ways to get it, and leader-boards that show top scores. Each website must go live the same day the game is released.

The Space Game website is a .NET Core app written in C# that's deployed to Linux. The website isn't finished yet, but here's what it looks like right now:

![](media/App_Overview.png)


