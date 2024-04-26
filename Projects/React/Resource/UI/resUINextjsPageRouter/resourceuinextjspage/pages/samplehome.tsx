import { revalidatePath } from "next/cache";

function SampleHomePage(props: any) {
  const { sample } = props;
  return (
    <div>
      <h1>The Sample home page: {sample}</h1>
    </div>
  );
}

export async function getStaticProps(context: any) {
  {
    const { params } = context;
    console.log("data---" + context);
    return {
      props: {
        sample: "context",
      },
      revalidate: 10,
    };
  }
}

export default SampleHomePage;
