"use client";
import SampleHomePage from "./samplehome";
import { useRouter } from "next/router";

function HomePage() {
  const router = useRouter();

  function Sample() {
    console.log("calling");
    router.push("/samplehome");
  }

  return (
    // <div>
    //   <h1>The home page</h1>
    //   <SampleHomePage></SampleHomePage>
    //   <SampleHomePage></SampleHomePage>
    //   <SampleHomePage></SampleHomePage>
    //   <SampleHomePage></SampleHomePage>
    //   <button onClick={Sample}>Click</button>
    // </div>
    <ul>
      <li>Option 1</li>
      <li>Option 2</li>
      <li>Option 3</li>
    </ul>
  );
}

export default HomePage;
