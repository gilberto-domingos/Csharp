import { CssBaseline } from "@mui/material";
import { AppRoutes } from "./routes/routes";
import { DrawerProvider } from "./shared/contexts";
import { SideMenu } from "./shared/components/side-menu";

export function App() {
  return (
    <DrawerProvider>
      <CssBaseline />
      <SideMenu>
        <AppRoutes />
      </SideMenu>
    </DrawerProvider>
  );
}

export default App;
