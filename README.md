# Tyler Enterprise Public Safety Remote Client Software Management Console - V1

[![DotNet Framework 4.8 Build Status](https://github.com/davasorus/TEPSClientManagementConsole-V1/actions/workflows/NetFXCI.yml/badge.svg?branch=live)](https://github.com/davasorus/TEPSClientManagementConsole-V1/actions/workflows/NetFXCI.yml)

[![DotNet 6.0 Build Status](https://github.com/davasorus/TEPSClientManagementConsole-V1/actions/workflows/dotnet.yml/badge.svg?branch=live)](https://github.com/davasorus/TEPSClientManagementConsole-V1/actions/workflows/dotnet.yml)


## This is the console designed to interact/manage the the pre reqs and client software to TEPS releases 22.1 SP 1 and above
 - Mobile
 - CAD
 - LERMS
 - CAD Indcident Obvserver

 ## Specifically interacts with the [Master Service](https://github.com/davasorus/TEPSClientInstallMasterService) which will forward messages onto the [Agent Service](https://github.com/davasorus/TEPSClientInstallServiceAgent) per machine
  - The agent service will need to be deployed onto each machine on the customer environment. This can be done VIA group policy, manual install, or a pending automated process.
  - The master service currently (as of 11/25/22) will need to be deployed manually, this should change to TEPS normal automated install/update process.
  - The agent and master services have the ability to update themselves once deployed.
