## Project Goal
This repository serves as a **Core Architecture (Bootstrap)** for WebGL projects. Using an isolated wallet feature (`WalletService`) as an example, it demonstrates the end-to-end integration of modern game development tools:
1. **Zenject** — manages the lifecycle and dependency resolution across layers.
2. **UniRx** — provides reactive binding between the wallet logic and the user interface, eliminating memory leaks.
3. **UniTask** — implements an asynchronous pattern for cloud API interactions(progress saving).
